// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace LexicographicallyArrays
{
    class LexicographicallyArrays
    {
        static void Main()
        {
            Console.Write("Please enter a first word: ");
            string strOne = Console.ReadLine();

            Console.Write("Please enter a second word: ");
            string strTwo = Console.ReadLine();

            int len = Math.Min(strOne.Length, strTwo.Length);

            if (strOne == strTwo)
            {
                Console.WriteLine("First word = Second word");
            }
            else
            {
                for (var i = 0; i < len; i++)
                {
                    if (strOne[i] > strTwo[i])
                    {
                        Console.WriteLine("The Second word is Forward on Lexicography");
                        break;
                    }
                    else if (strTwo[i] > strOne[i])
                    {
                        Console.WriteLine("The First word is Forward on Lexycography");
                        break;
                    }
                }

                if (strOne.Length > strTwo.Length)
                {
                    Console.WriteLine("The Second word is Forward on Lexicography");
                }
                else if (strOne.Length < strTwo.Length)
                {
                    Console.WriteLine("The First word is Forward on Lexicography");
                }
            }
        }
    }
}
