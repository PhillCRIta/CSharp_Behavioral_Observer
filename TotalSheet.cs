using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	internal class TotalSheet : IObserver
	{
		private int _total;
		private DataSource _dataSource;

		public TotalSheet(DataSource dataSource)
		{
			_dataSource = dataSource;
		}

		public void Update()
		{
			_total = CalculateTotal(_dataSource.GetValues());
		}

		private int CalculateTotal(List<int> values)
		{
			var sum = 0;
			foreach (int value in values)
			{
				sum += value;
			}
			Console.WriteLine("Total: " + sum);
			return sum;
		}
	}
}
