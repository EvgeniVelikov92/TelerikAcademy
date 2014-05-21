// Sort 3 real values in descending order using nested if statements.

using System;

namespace SortThreeValues
{
    class SortThreeValues
    {
        static void Main()
        {
            int first, second, third, bigger = 0;

            Console.Write("Please enter First Number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter Second Number: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Please enter Third Number: ");
            third = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                if (first < second)
                {
                    bigger = second;
                    second = first;
                    first = bigger;

                    if (first < third)
                    {
                        bigger = third;
                        third = first;
                        first = bigger;
                    }
                }
                else
                {
                    if (second < third)
                    {
                        bigger = third;
                        third = second;
                        second = bigger;
                    }
                }
            }

            Console.WriteLine(first + "; " + second + "; " + third);
        }
    }
}
