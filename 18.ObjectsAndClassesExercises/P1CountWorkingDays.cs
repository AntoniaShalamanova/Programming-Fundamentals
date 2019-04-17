using System;
using System.Collections.Generic;
using System.Globalization;

namespace P1CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDaysCounter = 0;
            bool isHoliday = false;

            List<DateTime> holidays = new List<DateTime>
            {
                DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture),

            };

            for (DateTime currentDay = startDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                if (currentDay.DayOfWeek == DayOfWeek.Saturday || currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    isHoliday = true;
                }

                for (int holiday = 0; holiday < holidays.Count; holiday++)
                {
                    if (currentDay.Month == holidays[holiday].Month && currentDay.Day == holidays[holiday].Day)
                    {
                        isHoliday = true;
                    }
                }

                if (!isHoliday)
                {
                    workingDaysCounter++;
                }

                isHoliday = false;
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
