// Write a method that reverses the digits of given decimal number. Example: 256 --> 652

using System;

namespace ReverseDigits
{
    class ReverseDigits
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Number: ");
            int n = int.Parse(Console.ReadLine());

            Reverse(n);
        }

        static void Reverse(int number)
        {
            string num = number.ToString();
            char[] reverseNumber = num.ToCharArray();
            Array.Reverse(reverseNumber);

            PrintNumber(reverseNumber);
        }

        static void PrintNumber(char[] revNumber)
        {
            string number = "";
            for (int index = 0; index < revNumber.Length; index++)
            {
                number += revNumber[index];
            }
            Console.WriteLine("The Reverse number is:    {0}\n", number);
        }
    }
}
