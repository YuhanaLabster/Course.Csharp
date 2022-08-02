using System;

namespace Labster
{
	public class OpeningHour
	{
		public TimeSpan OpeningTime { get; private set; }
		public TimeSpan ClosingTime { get; private set; }

		public OpeningHour(TimeSpan openingTime, TimeSpan closingTime)
		{
			OpeningTime = openingTime;
			ClosingTime = closingTime;
		}

		public OpeningHour(int openingHour, int closingHour)
		{
			OpeningTime = TimeSpan.FromHours(openingHour);
			ClosingTime = TimeSpan.FromHours(closingHour);
		}

	}
}
