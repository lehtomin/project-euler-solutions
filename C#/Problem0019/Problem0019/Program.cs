using System;

namespace Problem0019
{
    public class Program
    {
        static void Main()
        {
            var calendarUtils = new CalendarUtils();
            var startDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);

            var sundayOnFirstOfMonth = calendarUtils.GetSundaysThatAreOnTheFirstDayOfMonth(startDate, endDate);

            Console.WriteLine($"Number of Sundays on the first of the month during the 20th century: {sundayOnFirstOfMonth.Count}");
            Console.ReadKey();
        }
    }
}
