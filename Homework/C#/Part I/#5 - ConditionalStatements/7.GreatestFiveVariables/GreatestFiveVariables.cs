// Write a program that finds the greatest of given 5 variables.

using System;

namespace GreatestFiveVariables
{
    class GreatestFiveVariables
    {
        static void Main()
        {
            int first;
            int second;
            int third;
            int fourth;
            int fifth;

            Console.Write("Please enter a first number:  ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter a second number: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Please enter a third number:  ");
            third = int.Parse(Console.ReadLine());

            Console.Write("Please enter a fourth number: ");
            fourth = int.Parse(Console.ReadLine());

            Console.Write("Please enter a fifth number:  ");
            fifth = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    if (first > fourth)
                    {
                        if (first > fifth)
                        {
                            Console.WriteLine("The First {0} is Bigger", first);
                        }
                    }
                }
            }
            else if (second > first)
            {
                if (second > third)
                {
                    if (second > fourth)
                    {
                        if (second > fifth)
                        {
                            Console.WriteLine("The Second {0} is Bigger", second);
                        }
                    }
                }
            }
            else if (third > first)
            {
                if (third > second)
                {
                    if (third > fourth)
                    {
                        if (third > fifth)
                        {
                            Console.WriteLine("The Third {0} is Bigger", third);
                        }
                    }
                }
            }
            else if (fourth > first)
            {
                if (fourth > second)
                {
                    if (fourth > third)
                    {
                        if (fourth > fifth)
                        {
                            Console.WriteLine("The Fourth {0} is Bigger", fourth);
                        }
                    }
                }
            }
            else if (fifth > first)
            {
                if (fifth > second)
                {
                    if (fifth > third)
                    {
                        if (fifth > fourth)
                        {
                            Console.WriteLine("The Fifth {0} is Bigger", fifth);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Нямаме най-голямо число измежду петте числа.");
            }
        }
    }
}
