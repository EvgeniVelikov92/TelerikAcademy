// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        public static int CalculateEuclideanAlgorithm(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            CalculateEuclideanAlgorithm(a, b); 
        }
    }
}
