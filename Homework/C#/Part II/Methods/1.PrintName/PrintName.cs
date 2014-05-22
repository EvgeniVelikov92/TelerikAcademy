// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

namespace PrintName
{
    class PrintName
    {
        public static void PrintYourName()
        {
            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine();
            Console.Write("Hello ");
            Console.WriteLine(yourName + "!");
        }

        public static void Main(string[] args)
        {
            PrintYourName();
        }
    }
}
