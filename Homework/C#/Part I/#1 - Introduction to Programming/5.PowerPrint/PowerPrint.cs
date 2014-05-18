// Create a console application that calculates and prints the number 12345 raised to the power of 2.

using System;

namespace PowerPrint
{
    class PowerPrint
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int calcNum = number * number;

            Console.WriteLine("{0:n} * {0:n} = {1:n}", number, calcNum);
        }
    }
}
