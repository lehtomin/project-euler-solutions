using System;
using System.Collections.Generic;

namespace Problem0019
{
    public class CalendarUtils
    {
        public List<DateTime> GetSundaysThatAreOnTheFirstDayOfMonth(DateTime startDate, DateTime endDate)
        {
            var sundayOnFirstOfMonth = new List<DateTime>();
            var currentDate = startDate;
            while (currentDate < endDate)
            {
                if (IsSunday(currentDate))
                    sundayOnFirstOfMonth.Add(currentDate);
                currentDate = currentDate.AddMonths(1);
            }

            return sundayOnFirstOfMonth;
        }

        public bool IsSunday(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Sunday;
        }

        public int DaysInAMonth(int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Month has to be between 1 and 12!");
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            if (month == 2 && IsLeapYear(year))
                return 29;
            if (month == 2 && !IsLeapYear(year))
                return 28;

            return 31;
        }

        public bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}
