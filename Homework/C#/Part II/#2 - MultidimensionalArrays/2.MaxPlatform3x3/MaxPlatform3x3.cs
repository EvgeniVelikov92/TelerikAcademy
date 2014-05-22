// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

namespace MaxPlatform3x3
{
    class MaxPlatform3x3
    {
        static void Main()
        {
            Console.Write(" Rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write(" Cols = ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            Console.Write(" Minimal Value of Number = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write(" Maximal Value of Number = ");
            int max = int.Parse(Console.ReadLine());
            Random numberOfTheMatrix = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numberOfTheMatrix.Next(min, max);
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The biger Matrix 3x3 is:");
            Console.WriteLine(" {0}, {1}, {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine(" {0}, {1}, {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine(" {0}, {1}, {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("The biger Platform 3x3 is: {0}", bestSum);
        }
    }
}
