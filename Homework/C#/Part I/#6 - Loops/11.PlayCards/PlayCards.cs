// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

namespace PlayCards
{
    class PlayCards
    {
        static void Main()
        {
            for (int num = 2; num <= 14; num++)
            {
                for (int paint = 1; paint <= 4; paint++)
                {
                    if (paint == 1)
                    {
                        Console.Write("Пика ");
                    }
                    else if (paint == 2)
                    {
                        Console.Write("Купа ");
                    }
                    else if (paint == 3)
                    {
                        Console.Write("Каро ");
                    }
                    else
                    {
                        Console.Write("Спатия ");
                    }
                    Console.WriteLine(num);
                }
            }
        }
    }
}
