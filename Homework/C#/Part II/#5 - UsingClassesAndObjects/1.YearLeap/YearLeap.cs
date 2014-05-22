// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace YearLeap
{
    class YearLeap
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Please enter a Mounth (1-12): ");
            int mounth = int.Parse(Console.ReadLine());

            Console.Write("Please enter a Day: ");
            int day = int.Parse(Console.ReadLine());

            CheckedIntercalary(year, mounth, day);
        }

        static void CheckedIntercalary(int year, int mounth, int day)
        {
            DateTime intercalaryDate = new DateTime(year, mounth, day);
            Console.WriteLine(intercalaryDate);
            Console.WriteLine("{0}", DateTime.IsLeapYear(intercalaryDate.Year));
        }
    }
}
