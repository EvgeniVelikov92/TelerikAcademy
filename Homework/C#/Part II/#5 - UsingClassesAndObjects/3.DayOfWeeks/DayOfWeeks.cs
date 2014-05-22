// Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

namespace DayOfWeeks
{
    class DayOfWeeks
    {
        static void Main()
        {
            DateTime dayOfWeek = DateTime.Now;
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
