// Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

namespace CharacterSymbol
{
    class CharacterSymbol
    {
        static void Main()
        {
            int symbol;

            Console.Write("Please enter a number on symbol: ");
            symbol = int.Parse(Console.ReadLine());

            Console.WriteLine(" " + (char)symbol);
        }
    }
}
