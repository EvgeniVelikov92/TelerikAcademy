// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            decimal fFirst = 0;
            decimal fSecond = 1;
            decimal sum = 0;

            Console.WriteLine(fFirst + ";\n" + fSecond + ";");

            for (decimal i = 1; i <= 100; i++)
            {
                sum = fFirst + fSecond;
                fFirst = fSecond;
                fSecond = sum;
                Console.WriteLine("{0:N};", sum);
            }
        }
    }
}
