using System;
using System.Collections.Generic;

namespace Labster
{
	public class WeekCollection<T>
	{
		private Dictionary<DayOfWeek, T> _collection;

		public WeekCollection(
			T sunday, T monday, T tuesday, T wednesday, T thursday, T friday, T saturday)
		{
			_collection = new Dictionary<DayOfWeek, T>
			{
				{ DayOfWeek.Sunday, sunday },
				{ DayOfWeek.Monday, monday },
				{ DayOfWeek.Tuesday, tuesday },
				{ DayOfWeek.Wednesday, wednesday },
				{ DayOfWeek.Thursday, thursday },
				{ DayOfWeek.Friday, friday },
				{ DayOfWeek.Saturday, saturday }
			};
		}

		public T Get(DayOfWeek dayOfWeek)
		{
			return _collection[dayOfWeek];
		}
	}
}
