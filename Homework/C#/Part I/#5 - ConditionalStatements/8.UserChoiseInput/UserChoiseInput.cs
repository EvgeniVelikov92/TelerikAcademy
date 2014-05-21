// Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

namespace UserChoiseInput
{
    class UserChoiseInput
    {
        static void Main()
        {
            Console.Write("Please enter a number (1-3) Integer - 1; Double - 2; String - 3:    ");
            char click = char.Parse(Console.ReadLine());

            switch (click)
            {
                case '1':
                    {
                        int a;
                        Console.Write("Вие натиснахте 1 Integer: Моля въведете число: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("{0} + 1 = {1}", a, (a + 1));
                        break;
                    }
                case '2':
                    {
                        double b;
                        Console.Write("Вие натиснахте 2 Double: Моля въведете число:  ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0} + 1 = {1}", b, (b + 1));
                        break;
                    }
                case '3':
                    {
                        string c;
                        Console.Write("Вие натиснахте 3 String: Моля въведете текст:  ");
                        c = Console.ReadLine();
                        Console.WriteLine("{0}*", c);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Не сте натиснали нищо от 1-3");
                        break;
                    }
            }
        }
    }
}
