// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main()
        {
            Console.Write(" N = ");
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" [{0}] [{1}] ", row + 1, col + 1);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[col, row]);
                }
                Console.WriteLine();
            }
        }
    }
}
