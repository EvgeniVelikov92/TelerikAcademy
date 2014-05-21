// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

namespace CalculateNFaqMultipliedKFaq
{
    class CalculateNFaqMultipliedKFaq
    {
        static void Main()
        {
            Console.WriteLine("---------------------------N!*K!/(N-1)!---------------------------");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int faqturN = 1;
            int FaqturK = 1;
            int faqtur = 1;
            int result = 0;

            if (n > k && k > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    faqturN *= i;
                }

                Console.WriteLine(faqturN);

                for (int i = 1; i <= k; i++)
                {
                    FaqturK *= i;
                }

                Console.WriteLine(FaqturK);

                for (int i = 1; i <= n - k; i++)
                {
                    faqtur *= i;
                }

                Console.WriteLine(faqtur);

                result = (faqturN * FaqturK) / faqtur;
                Console.WriteLine(result);
            }
        }
    }
}
