// Write a program to read your age from the console and print how old you will be after 10 years.

using System;

namespace PrintAge
{
    class PrintAge
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is: {0}\nYour ange after 10 years is: {1}", age, age + 10);
        }
    }
}
