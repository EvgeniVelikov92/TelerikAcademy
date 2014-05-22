// Write a program that reads two arrays from the console and compares them element by element.

using System;

namespace ComparesArray
{
    class ComparesArray
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[m];
            bool check = false;

            if (n == m)
            {
                for (int index = 0; index < n; index++)
                {
                    Console.Write("ArrOne [{0}] = ", index);
                    arrOne[index] = int.Parse(Console.ReadLine());
                    Console.Write("ArrTwo [{0}] = ", index);
                    arrTwo[index] = int.Parse(Console.ReadLine());
                    if (arrOne[index] == arrTwo[index])
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        Console.WriteLine("Масивите не са еднакви");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Масивите не са еднакви");
            }

            if (check == true)
            {
                Console.WriteLine("Масивите са еднакви");
            }
        }
    }
}
