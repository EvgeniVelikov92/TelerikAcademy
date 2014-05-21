// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

namespace CalculateNFaqKFaq
{
    class CalculateNFaqKFaq
    {
        static void Main()
        {
            Console.WriteLine("---------------------------N!/K!---------------------------");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int faqturN = 1;
            int faqturK = 1;
            int result = 0;

            if (n > k && k > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    faqturN *= i;
                }

                for (int i = 1; i <= k; i++)
                {
                    faqturK *= i;
                }

                Console.WriteLine(faqturN);
                Console.WriteLine(faqturK);

                result = faqturN / faqturK;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
