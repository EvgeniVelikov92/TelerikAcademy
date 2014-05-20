// Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) --> false;  (5.00000001 ; 5.00000003) --> true.

using System;

namespace SafelyComparesFloat
{
    class SafelyComparesFloat
    {
        static void Main()
        {
            float firstNum = 5.3f;
            float secondNum = 6.1f;
            float thirdNum = 5.00000001f;
            float fourthNum = 5.00000003f;
            bool first = firstNum == secondNum;
            bool second = thirdNum == fourthNum;

            Console.WriteLine("{0} = {1} --> {2}", firstNum, secondNum, first);
            Console.WriteLine("{0} = {1} --> {2}", thirdNum, fourthNum, second);
        }
    }
}
