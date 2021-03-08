using System;

namespace коренуване
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(SqrtBabyLon(100)); // 2455489
        }

        static double SqrtBabyLon(double num)
        {
            double xPrev = num, x = num;

            do
            {
                Console.WriteLine(x); // 8 стъпки за 100
                xPrev = x;
                x = 0.5 * (xPrev + num / xPrev);
            }
            while (xPrev - x > 0.0000001);

           // for (int i = 0; i < 50; i++)
           // {
           //    x = 0.5 * (x + num / x);
          //  }
            return x;
        }
    }
}
