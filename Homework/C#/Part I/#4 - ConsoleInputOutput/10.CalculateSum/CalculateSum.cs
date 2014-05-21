// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

namespace CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            float first;
            float second;
            float third;
            float fourth;
            float fifth;
            float result;

            Console.Write("First = ");
            first = float.Parse(Console.ReadLine());

            Console.Write("Second = ");
            second = float.Parse(Console.ReadLine());

            Console.Write("Third = ");
            third = float.Parse(Console.ReadLine());

            Console.Write("Fourth = ");
            fourth = float.Parse(Console.ReadLine());

            Console.Write("Fifth = ");
            fifth = float.Parse(Console.ReadLine());

            result = first + second + third + fourth + fifth;
            Console.WriteLine("Result = {0:N3}", result);
        }
    }
}
