// Write a program that can solve these tasks: Reverses the digits of a number. Calculates the average of a sequence of integers. Solves a linear equation a * x + b = 0. Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve. Validate the input data: The decimal number should be non-negative. The sequence should not be empty. a should not be equal to 0.

using System;

namespace MenuProgrammQuadraticEquation
{
    class MenuProgrammQuadraticEquation
    {
        static void Main(string[] args)
        {
            string menu = @"Please enter 1-3 from Menu for running a Programm:
1. Reversal Number
2. Average Series Numbers
3. Уравнение
";
            Console.WriteLine(menu);

            Console.Write("Please Enter From 1 To 3: ");
            char clickMenu = char.Parse(Console.ReadLine());

            ClickMenu(clickMenu);
        }

        // Menu Code
        static void ClickMenu(char click)
        {
            if (click == '1')
            {
                Reversal();
            }
            else if (click == '2')
            {
                Average();
            }
            else if (click == '3')
            {
                Equation();
            }
            else
            {
                return;
            }
        }

        // Click 1 - Reversal
        static void Reversal()
        {
            Console.Write("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                string number = num.ToString();

                ReversNumber(number);
            }
            else
            {
                return;
            }
        }

        static void ReversNumber(string value)
        {
            char[] revNumber = value.ToCharArray();
            Array.Reverse(revNumber);
            string number = "";

            for (int index = 0; index < revNumber.Length; index++)
            {
                number += revNumber[index];
            }

            Console.WriteLine(number);
        }

        // Click 2 - Average
        static void Average()
        {
            Console.Write("Please enter a length of Serios of Numbers: ");
            int n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                AverageSeriosOfNumber(n);
            }
            else
            {
                return;
            }
        }

        static void AverageSeriosOfNumber(int number)
        {
            int[] numArray = new int[number];
            double averageNumbers = 0;

            for (int index = 0; index < numArray.Length; index++)
            {
                Console.Write("Number {0:}: ", index + 1);
                numArray[index] = int.Parse(Console.ReadLine());

                averageNumbers += numArray[index];
            }

            double averageNumber = averageNumbers / number;
            Console.WriteLine("Average Number of Seris of Numbers is: {0:N}", averageNumber);
        }

        // Click 3 - Equation a * x + b = 0
        static void Equation()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                CalculateEquation(a, b);
            }
            else
            {
                return;
            }
        }

        static void CalculateEquation(double varA, double varB)
        {
            double calculation = -varB / varA;
            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x = " + calculation);
        }
    }
}
