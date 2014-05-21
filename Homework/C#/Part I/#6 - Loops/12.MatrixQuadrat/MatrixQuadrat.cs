// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

using System;

namespace MatrixQuadrat
{
    class MatrixQuadrat
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int column = row; column <= n + row - 1; column++)
                {
                    Console.Write(column + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
