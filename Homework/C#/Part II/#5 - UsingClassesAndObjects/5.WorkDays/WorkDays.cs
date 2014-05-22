// Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

namespace WorkDays
{
    class WorkDays
    {
        static void Main(string[] args)
        {
            DateTime startDay = DateTime.Today;
            Console.WriteLine("Enter a end date in YYYY/MM/DD format");
            string[] endDateStr = Console.ReadLine().Split('/');

            int day = int.Parse(endDateStr[2]);
            int mounth = int.Parse(endDateStr[1]);
            int year = int.Parse(endDateStr[0]);

            DateTime endDate = new DateTime(year, mounth, day);
            Console.WriteLine(endDate);
            int timelen = Math.Abs((endDate - startDay).Days);

            if (startDay > endDate)
            {
                startDay = endDate;
                endDate = DateTime.Today;
            }

            DateTime[] holidays =
            {
                new DateTime(2013, 1, 1),
                new DateTime(2012, 2, 2),
                new DateTime(2012, 3, 3),
                new DateTime(2012, 4, 4),
                new DateTime(2013, 1, 18)
            };

            Console.WriteLine("Days until now: " + timelen);
            int workDayCounter = 0;
            bool isHoliday = false;

            for (int i = 0; i < timelen; i++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDay == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }

                    isHoliday = false;
                }
            }

            Console.WriteLine("Working days during this period: " + workDayCounter);
        }
    }
}
