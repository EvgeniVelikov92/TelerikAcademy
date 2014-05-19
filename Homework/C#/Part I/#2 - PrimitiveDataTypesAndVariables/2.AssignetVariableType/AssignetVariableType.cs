// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

namespace AssignetVariableType
{
    class AssignetVariableType
    {
        static void Main(string[] args)
        {
            double first = 34.567839023;
            float second = 12.345f;
            double third = 8923.1234857;
            float fourth = 3456.091f;

            Console.WriteLine("First number: " + first);
            Console.WriteLine("Second number: " + second);
            Console.WriteLine("Third number: " + third);
            Console.WriteLine("Fourth number: " + fourth);
        }
    }
}
