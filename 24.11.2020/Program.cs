namespace _24._11._2020
{
    using System;

    class Program
    {
        static void Main()
        {
            // Console.WriteLine(Factorial(6));
            CountDown(5);
        }

        static int Factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return Factorial(n - 1) * n;
        }

        static void CountDown(int start)
        {
            if (start == 0)
            {
                return;
            }
            Console.WriteLine(start);
            CountDown(start - 1);
        }
    }
}
