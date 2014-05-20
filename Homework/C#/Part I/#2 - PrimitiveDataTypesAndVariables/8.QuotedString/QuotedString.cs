// Declare two string variables and assign them with following value: Do the above in two different ways: with and without using quoted strings.

using System;

namespace QuotedString
{
    class QuotedString
    {
        static void Main()
        {
            string first;
            string second;
            first = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine("\n " + first);
            second = "The \"use\" of quotations causes difficulties";
            Console.WriteLine("\n " + second + "\n");
        }
    }
}