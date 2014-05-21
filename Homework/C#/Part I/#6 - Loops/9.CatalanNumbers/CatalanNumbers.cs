// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:

using System;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = 1;
            decimal faqtN = 1;
            decimal faqtTwoN = 1;
            decimal faqtNOne = 1;
            decimal catal = 1;

            Console.WriteLine("---------------------Catalan's numbers---------------------");

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    faqtN *= i;
                }

                Console.WriteLine("n! = {0:N}", faqtN);

                for (int i = 1; i <= 2 * n; i++)
                {
                    faqtTwoN *= i;
                }

                Console.WriteLine("(2n)! = {0:N}", faqtTwoN);

                for (int i = 1; i <= n + 1; i++)
                {
                    faqtNOne *= i;
                }

                Console.WriteLine("(n + 1)! = {0:N}", faqtNOne);
                Console.WriteLine();

                catal = faqtTwoN / (faqtNOne * faqtN);
                Console.WriteLine("Cn = (2n)!/(n + 1)!n! = {0:N}", catal);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
