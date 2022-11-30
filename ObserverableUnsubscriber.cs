using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalDistributionGraph
{
	class ObserverableUnsubscriber<T> : IDisposable
	{
		private List<IObserver<T>> _subscribers;
		private IObserver<T> _subscriber;


		public ObserverableUnsubscriber(List<IObserver<T>> subscribers, IObserver<T> subscriber)
		{
			_subscribers = subscribers;
			_subscriber = subscriber;
		}



		public void Dispose()
		{
			if (_subscribers.Contains(_subscriber))
			{
				_subscribers.Remove(_subscriber);
			}
		}
	}
}
