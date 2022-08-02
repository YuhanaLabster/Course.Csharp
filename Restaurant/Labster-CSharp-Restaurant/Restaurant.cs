using System;

namespace Labster
{
	public class Restaurant
	{
		public WeekCollection<OpeningHour> OpeningHours { get; private set; }

		public Restaurant()
		{
			// No opening hours available for restaurant
		}

		public Restaurant(
			OpeningHour monday,
			OpeningHour tuesday,
			OpeningHour wednesday,
			OpeningHour thursday,
			OpeningHour friday,
			OpeningHour saturday,
			OpeningHour sunday)
		{
			OpeningHours = new WeekCollection<OpeningHour>(
				monday, tuesday, wednesday, thursday, friday, saturday, sunday);
		}

		public string GetOpeningHours()
		{
			// TODO: Implement
			throw new NotImplementedException();
		}
	}
}
