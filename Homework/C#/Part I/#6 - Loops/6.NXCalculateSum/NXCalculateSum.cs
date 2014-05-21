// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

namespace NXCalculateSum
{
    class NXCalculateSum
    {
        static void Main()
        {
            decimal s = 0;
            decimal n;
            decimal x;
            decimal factorialN = 1;
            decimal poweredX = 1;

            Console.Write("n = ");
            n = decimal.Parse(Console.ReadLine());

            Console.Write("x = ");
            x = decimal.Parse(Console.ReadLine());

            for (decimal i = 1; i <= n; i++)
            {
                factorialN *= i;
                poweredX *= x;             
            }

            s = 1 + factorialN / poweredX;

            Console.WriteLine("The Sum = {0}", s);
        }
    }
}
