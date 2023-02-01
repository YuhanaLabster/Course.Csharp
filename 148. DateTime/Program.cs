using System;

namespace _148._DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeDelta("1988-04-22"));
        }

        static DateTime GetToday()
        {
            return DateTime.Today;
        }

        static DateTime GetTomorow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }

        static DateTime CurrentTime()
        {
            return DateTime.Now;
        }

        static DayOfWeek DayName()
        {
            return DateTime.Today.DayOfWeek;
        }

        static string CustomDate()
        {
            string result = $"{GetToday()} | {DayName()}" ;
            return result;
        }

        static string FirstDayOfTheYear(int year,int month, int day)
        {
            string name =  new DateTime(year,month,day).DayOfWeek.ToString();
            string result = $"the day for : {year}-{month}-{day} is {name}";
            return result;
        }

        static string DaysInAMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year,month);
            return $"Amount of day in {year}-{month} is {days}";
        }

        static string GetCurrentTime()
        {
            DateTime Now = DateTime.Now;
            return $"{Now.Hour} O'Clock : {Now.Minute} Minutes : {Now.Second} Seconds";
        }

        static string TimeDelta(string input)
        {
            DateTime dateTime = new DateTime();
            if (DateTime.TryParse(input, out dateTime))
            {
                TimeSpan dayPassed = CurrentTime().Subtract(dateTime);
                return $"Its {dayPassed.Days/365} year, {dayPassed.Days/ 30.417/12} months ago";
            }
            return "wrong format";
        }
    }   

}
