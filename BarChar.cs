using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	//Concrete observer
	//EXTEND - BlackArrow IObserver interface
	internal class BarChar : IObserver
	{
		private DataSource _dataSource;

		//in this case ConcreteObserver is composed (keep a reference) to a ConcreteSubject (Datasource class)
		//PULL STYLE
		public BarChar(DataSource dataSource)
		{
			_dataSource = dataSource;
		}

		public void Update()
		{
			Console.WriteLine("Rendering bar chart with new values");
			foreach (int value in _dataSource.GetValues())
			{
				Console.WriteLine("Value: " + value);
			}
		}
	}
}
