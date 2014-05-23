// Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 

using System;

namespace CalculateSquareRoot
{
    class CalculateSquareRoot
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            SQRTNumbers(number);
        }

        static void SQRTNumbers(string number)
        {
            try
            {
                int squareNum = (int)Math.Sqrt(Int32.Parse(number));
                Console.WriteLine("Your result is = " + squareNum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format! ");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid Number! ");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
