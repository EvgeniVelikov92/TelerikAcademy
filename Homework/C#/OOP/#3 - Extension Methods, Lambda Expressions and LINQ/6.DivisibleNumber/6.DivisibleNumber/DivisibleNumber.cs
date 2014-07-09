namespace DivisibleNumber
{
    using System;
    using System.Collections.Generic;

    public static class DivisibleNumber
    {
        public static void DivisibleNumbers(this int[] numbers, int firstNumber, int secondNumber)
        {
            List<int> listOfNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (num % firstNumber == 0 || num % secondNumber == 0)
                {
                    listOfNumbers.Add(num);
                }
            }

            foreach (var num in listOfNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
