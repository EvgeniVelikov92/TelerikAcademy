// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

namespace GetMax
{
    class GetMax
    {
        public static void GetMax(int first, int second)
        {
            int max = first;
            if (first < second)
            {
                max = second;
                Console.WriteLine(second);
                Console.WriteLine("Second > First");
            }
            else if (first == second)
            {
                Console.WriteLine("Second == First");
            }
            else
            {
                Console.WriteLine(first);
                Console.WriteLine("First > Second");
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second Number = ");
            int secondNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber);
        }
    }
}
