// Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

namespace NameOfTheDigit
{
    class NameOfTheDigit
    {
        static void Main()
        {
            int num;

            Console.Write("Please enter a number (0-9): ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    {
                        Console.WriteLine("{0} = Нула: Null", num);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("{0} = Едно: One", num);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("{0} = Две: Two", num);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("{0} = Три: Three", num);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("{0} = Четери: Four", num);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("{0} = Пет: Fifth", num);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("{0} = Шест: Sixth", num);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("{0} = Седем: Seven", num);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("{0} = Осем: Eight", num);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("{0} = Девет: Nine", num);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Грешка не сте избрали число от посочения интервал:");
                        break;
                    }
            }
        }
    }
}
