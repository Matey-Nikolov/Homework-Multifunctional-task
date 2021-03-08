using System;

namespace TEST2021_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(EuclidGCD(num1, num2));
            Console.WriteLine(LCM(num1, num2));
        }

        static int EuclidGCD(int a, int b)
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

        static int LCM(int a, int b)
        {
            return (a * b) / EuclidGCD(a, b);
        }
    }
}