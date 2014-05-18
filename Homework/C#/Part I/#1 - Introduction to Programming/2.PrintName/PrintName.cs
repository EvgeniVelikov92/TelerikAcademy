// Modify the application to print your name.

using System;

namespace PrintName
{
    class PrintName
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your first name is: {0}\nYour last name is: {1}\nYour full name is: {0} {1}", firstName, lastName);
        }
    }
}