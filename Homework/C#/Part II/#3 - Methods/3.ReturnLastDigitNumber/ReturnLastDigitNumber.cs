// Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

namespace ReturnLastDigitNumber
{
    class ReturnLastDigitNumber
    {
        public static void LastDigitNumber(int lastDigit)
        {
            int lastNumber = lastDigit % 10;

            PrintLastDigit(lastNumber);
        }

        public static void PrintLastDigit(int printNumber)
        {
            switch (printNumber)
            {
                case 0:
                    {
                        Console.WriteLine(" " + printNumber + " = Zero ");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine(" " + printNumber + " = One ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" " + printNumber + " = Two ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" " + printNumber + " = Three ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" " + printNumber + " = Four ");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" " + printNumber + " = Five ");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(" " + printNumber + " = Six ");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(" " + printNumber + " = Seven ");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine(" " + printNumber + " = Eight");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine(" " + printNumber + " = Nine ");
                        break;
                    }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            LastDigitNumber(number);
        }
    }
}
