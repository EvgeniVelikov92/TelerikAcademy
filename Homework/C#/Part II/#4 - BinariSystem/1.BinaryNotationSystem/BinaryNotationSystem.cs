using System;

namespace BinaryNotationSystem
{
    class BinaryNotationSystem
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int system = 2;
            int sum = number;
            int bin = 0;
            string s = string.Empty;
            while (sum == number && sum > 0)
            {
                sum = number / system;
                bin = number % system;
                number = sum;
                s += bin.ToString();
            }
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.WriteLine();
        }
    }
}
