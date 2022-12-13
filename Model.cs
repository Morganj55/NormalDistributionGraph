using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using MathNet.Numerics;
using BuisnessLogic_and_Data;

namespace NormalDistributionGraph
{
    public class Model : IModel
    {
        //View properties
        public bool meanValidated { get; set; }
        public bool stdDevValidated { get; set; }
        public bool enableProbPanelDistBtn { get; set; }
        public float mean { get; set; }
        public float stdDev { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
      
        //Probability Properties 
        public string A1Probability { get; set; } 
        public string A2B2Probability { get; set; }
        public string B1Probability {get; set;}

        //CustomCurve properties
        private readonly CustomCurve _customCurve;
        public Rectangle rectangle
        {
            get { return _customCurve.rectangle; }
            set { _customCurve.rectangle = value; }
        }
        public PointF startingPoint
        {
            get { return _customCurve.startingPoint; }
            set { _customCurve.startingPoint = value; }
        }

        //Observer Properties
        public List<IObserver<ModelUpdate>> _observers; 

        //Constructor
        public Model()
        {
            _observers = new List<IObserver<ModelUpdate>>();
            _customCurve = new CustomCurve();
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
        public PointF[] GenerateCurve()
        {
            _customCurve.CreateXCoordinates(mean, stdDev);
            _customCurve.CreateYCoordinates(mean, stdDev);
            _customCurve.CreateGraphXCoordinates(rectangle, startingPoint);
            _customCurve.CreateGraphYCoordinates(rectangle, startingPoint);
            _customCurve.GraphAddXandYToPointArray();
            return _customCurve.GraphXYArray;
        }
        public PointF[] GenerateSDLines()
        {
            _customCurve.CreateSDLinePoints();
            return _customCurve.GraphSDLines;
        }
        public void UpdateProbabilities()
        {
           A1Probability = Algorithm.CalculateProbabilityPercentage_XLessThanA(A1, mean, stdDev);
           A2B2Probability = Algorithm.CalculateProbabilityPercentage_ALessThanXLessThanB(A2, B2, mean, stdDev);
           B1Probability = Algorithm.CalculateProbabilityPercentage_XGreaterThanB(B1, mean, stdDev);
            SendMessage(new ModelUpdate(enableProbPanelDistBtn, A1Probability, A2B2Probability, B1Probability));
        }
        public void Reset()
        {
            _customCurve.Reset();
        }

        

    }
}
