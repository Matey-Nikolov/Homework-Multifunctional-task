using System;

namespace _2021TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CountEvenDigit(number)); // 1356979465
        }


        static int CountEvenDigit(int number)
        {
            int count = 0;
            while (number != 0)
            {
                int gigit = number % 10;
                if (gigit % 2 == 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }
    }
}
