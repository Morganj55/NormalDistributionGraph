using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalDistributionGraph
{
    class Model : IModel
    {       
        public bool meanValidated { get; set; }
        public bool stdDevValidated { get; set; }
        public bool enableProbPanelDistBtn { get; set; }
        public float mean { get; set; }
        public float stdDev { get; set; }
        public float A1 { get; set; }
        public float A2 { get; set; }
        public float B1 { get; set; }
        public float B2 { get; set; }
        private List<IObserver<ModelUpdate>> _observers;
        public Model()
        {
            _observers = new List<IObserver<ModelUpdate>>();
        }

        //IObserverable methods 

        public void SendMessage(ModelUpdate update)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(update);
            }
        }

        public IDisposable Subscribe(IObserver<ModelUpdate> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new ObserverableUnsubscriber<ModelUpdate>(_observers, observer);
        }

        //Methods called by presenters 
        public void UpdateProbabiltyPanelAndDistributionButton()
        {
            if (meanValidated == true && stdDevValidated == true)
            {
                enableProbPanelDistBtn = true;
                SendMessage(new ModelUpdate(enableProbPanelDistBtn));
            }
            else
            {
                enableProbPanelDistBtn = false;
                SendMessage(new ModelUpdate(enableProbPanelDistBtn));
            }
        }

    }
}
