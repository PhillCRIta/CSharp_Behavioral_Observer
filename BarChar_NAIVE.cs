using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	internal class BarChar_NAIVE
	{
		public void Render(List<int> values)
		{
			Console.WriteLine("Rendering bar chart with new values");
			foreach (int value in values)
			{
				Console.WriteLine("Value: " + value);
			}
		}
	}
}
