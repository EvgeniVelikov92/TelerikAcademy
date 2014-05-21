// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

namespace NNumberSum
{
    class NNumberSum
    {
        static void Main()
        {
            int n;
            int sum = 0;

            Console.Write("Please enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
                Console.WriteLine(" " + sum);
            } 
        }
    }
}
