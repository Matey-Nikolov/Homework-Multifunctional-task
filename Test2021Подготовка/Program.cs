namespace Test2021Подготовка
{
    using System;
    
    class Program
    {
        static void Main()
        { 
            Console.WriteLine(Euclid1GCD(125,25));
        }

        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static int GCD(int a, int b)
        {
            for(int i = Math.Min(a, b); i >= 1; i--)
            {
                if(a % i == 0 &&  b % i == b)
                {
                    return i;
                }
            }
            return 1;
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

        static int Euclid2GCD(int a, int b)
        {
            while (a != b)
            {
                if (a < b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
                else
                    a -= b;
            }
            return a;
        }

        static int Euclid3GCD(int a, int b)
        {
            while (b != 0)
            {
                    a %= b;
                    int temp = a;
                    a = b;
                    b = temp;
            }
            return a;
        }
    }
}
