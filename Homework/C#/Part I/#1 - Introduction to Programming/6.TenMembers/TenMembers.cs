// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

namespace TenMembers
{
    class TenMembers
    {
        static void Main(string[] args)
        {
            for (int i = 2, k = -3; i <= 99; k = -i - 1, i++, k--)
            {
                Console.Write(i + " " + k + " ");
                i++;
            }
        }
    }
}