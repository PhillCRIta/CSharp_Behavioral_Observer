using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Observer
{
	internal class DataSource_NAIVE
	{
		private List<int> _values = new List<int>();
		private List<Object> _dependents = new List<Object>();

		public List<int> GetValues()
		{
			return _values;
		}
		public void SetValues (List<int> values) { 
			_values = values;
			foreach (Object dependent in _dependents)
			{
				if(dependent is TotalSheet_NAIVE)
				{
					(dependent as TotalSheet_NAIVE).CalculateTotal(_values);
				}else if (dependent is BarChar_NAIVE)
				{
					(dependent as BarChar_NAIVE).Render(_values);
				}
			}
		}	
		public void AddDependent(Object dependent)
		{
			_dependents.Add(dependent);
		}
		public void RemoveDependent(Object dependent)
		{
			_dependents.Remove(dependent);
		}
	}
}
