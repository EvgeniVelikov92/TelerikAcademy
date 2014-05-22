// Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Numerics;

namespace CalculateFaqturial
{
    class CalculateFaqturial
    {
        static void Calculate(BigInteger number)
        {
            BigInteger facturial = 1;
            Console.Write("{0:N}! = ", number);
            for (int i = 1; i <= number; i++)
            {
                facturial *= i;
            }

            Console.WriteLine(facturial);
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a facturial length: ");
            int n = int.Parse(Console.ReadLine());

            Calculate(n);
        }
    }
}
