// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

namespace FindingThirdBit
{
    class FindingThirdBit
    {
        static void Main()
        {
            int num;
            int p = 3;
            int byt;
            int nanbyt;

            Console.Write("Please enter a number:   ");
            num = int.Parse(Console.ReadLine());

            byt = num >> p;
            nanbyt = num & 1;

            Console.WriteLine("Числото побитово изместено на дясно с 3 е: " + byt);
            Console.WriteLine("Третия бит от числото е: " + nanbyt);
        }
    }
}
