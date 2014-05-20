// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int a, b, c;

            Console.Write("Please enter a number of 'a': ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number of 'b': ");
            b = int.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            Console.WriteLine("The number of 'A': " + a);
            Console.WriteLine("The number of 'B': " + b);
        }
    }
}
