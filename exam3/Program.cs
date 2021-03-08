using System;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine(ReturnEuclidGCD(num1, num2));
            Console.WriteLine(ReturnLCM(num1, num2));
        }

        static int ReturnEuclidGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                num1 %= num2;
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            return a;
        }

        static int ReturnLCM(int num1, int num2)
        {
            return (a * b) / ReturnEuclidGCD(num1, num2);
        }
    }
}
