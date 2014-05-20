// Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace HelloWorldObject
{
    class HelloWorldObject
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object variable;
            variable = first + " " + second;
            Console.WriteLine(" " + variable + "!");
        }
    }
}