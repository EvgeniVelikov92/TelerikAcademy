// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 

using System;

namespace ReminderOfTheDivision
{
    class ReminderOfTheDivision
    {
        static void Main()
        {
            int first;
            int second;
            int result = 0;

            Console.Write("Please enter a first number:  ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter a second number: ");
            second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {              
                if (i % 5 == 0)
                {
                    Console.WriteLine(i + " ");
                    result++;
                }
            }

            Console.WriteLine("The Numbers 5 exist between them such that the reminder of the division by 5 is: " + result);
        }
    }
}
