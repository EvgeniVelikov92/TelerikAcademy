// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

namespace FibonacchiNumbers
{
    class FibonacchiNumbers
    {
        static void Main()
        {
            decimal fibOne = 0;
            decimal fibTwo = 1;
            decimal sum = 0;
            decimal n = 0;

            Console.Write("n = ");
            n = decimal.Parse(Console.ReadLine());

            for (decimal i = fibOne; i <= n; i++)
            {
                sum = fibOne + fibTwo;
                fibOne = fibTwo;
                fibTwo = sum;
                Console.WriteLine("{0:N}", sum);
            }
        }
    }
}
