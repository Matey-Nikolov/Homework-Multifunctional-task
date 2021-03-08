using System;

namespace пресмятанеНаЧислотоП
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("PI = " + CalcPI1());

            Console.WriteLine("PI = " + CalcPI2(10));
            Console.WriteLine("PI = " + CalcPI2(100));
            Console.WriteLine("PI = " + CalcPI2(10000));
        }

        static double CalcPI1()
        {
            double pi = 1;       // - 1.0/ 3.0 + 1.0 / 5.0 - 1.0 / 7.0 + 1.0/9.0 - 1.0/11.0;
           // int cnt = 0;

            for (int i = 3, cnt = 0; i < 100000; i += 2, cnt++)
            {
                if(cnt % 2 == 0)
                {
                    pi -= (double) 1 / i;
                }
                else
                {
                    pi += (double)1 / i;
                }
            }

            pi *= 4;
            return pi;
        }


        static double CalcPI2(int n)
        {
            double pi = 0;

            for (int k = 0; k < n; k++)
            {
                pi += Math.Pow(- 1, k) / (2 * k + 1);
            }

            pi *= 4;

            return pi;
        }
    }
}
