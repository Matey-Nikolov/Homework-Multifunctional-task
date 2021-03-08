namespace Protect1crokocenka6
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>(); // 25 30 

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            int powerNum = 0;

            Console.WriteLine(Euclid1GCD(isPower(numbers, k), isPower(numbers, k)));
        }

        static int isPower(List<int> x, int y)
        {
            int pow = 1;

            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] == 1)
                    return y = 1;


                while (pow < y)
                    pow = pow * x[i];
            }

            return pow = y;
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
    }
}
