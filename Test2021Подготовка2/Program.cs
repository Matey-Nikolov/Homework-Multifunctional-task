namespace Test2021Подготовка2
{
    using System;

    class Program
    {
        static void Main()
        {
            // 125, 10, 100
            int a = 20, b = 10, c = 15;

            int max = LCM2(LCM2(a, b), c);
            Console.WriteLine(max);
        }

        static int LCM(int a, int b)
        {
            for (int i = Math.Max(a, b); i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    return i;
                }
            }
            return a * b;
        }

        static int Euclid1GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        static int LCM2(int a, int b)
        {
            return (a * b) / Euclid1GCD(a, b);
        }

    }
}
