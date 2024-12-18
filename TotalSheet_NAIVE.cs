using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	internal class TotalSheet_NAIVE
	{
		private int _total;
		public int GetTotal()
		{
			return _total;
		}
		public int CalculateTotal(List<int> values)
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
