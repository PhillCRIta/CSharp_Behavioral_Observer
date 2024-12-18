using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	internal class Subject
	{
		//DIAMOND ARROW
		//Subject is composed with polimorphism by IObserver objects
		//MANAGE THE OBSERVERS
		private List<IObserver> _observers = new List<IObserver>();

		public void AddObserver(IObserver observer)
		{
			_observers.Add(observer);
		}
		public void RemoveObserver(IObserver observer)
		{
			_observers.Remove(observer);
		}
		public void NotifyObserver()
		{
			foreach (IObserver observer in _observers)
			{
				//is needn't check the type of observer
				//i can add any parameters to update function and use those parameters to update the observers
				//instead of keep the value inside a observer classes
				//this is PUSH STYLE OBSERVER
				observer.Update();
			}
		}
	}
}
