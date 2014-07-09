namespace DivisibleNumber
{
    using System;
    using System.Collections.Generic;

    public class Demos
    {
        public static void Main()
        {
            int[] arrNumber = { 2, 3, 5, 66, 22, 21, 3, 5, 6, 9, 4, 8, 2, 4, 2, 6 };
            arrNumber.DivisibleNumbers(3, 7);
            Console.WriteLine(arrNumber);
        }
    }
}
