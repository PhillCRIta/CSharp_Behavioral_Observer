namespace Behavioral_Observer
{
	//BLACK ARROW
	//EXTEND - Subject class
	//Data source IS-A subject
	internal class DataSource : Subject
	{
		private List<int> _values = new List<int>();
		public List<int> GetValues()
		{
			return _values;
		}

		public void SetValues(List<int> values)
		{
			_values = values;
			NotifyObserver();
		}
	}
}