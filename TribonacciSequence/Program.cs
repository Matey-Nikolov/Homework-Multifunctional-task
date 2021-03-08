namespace TribonacciSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            
            int num = int.Parse(Console.ReadLine());
            PrintNumber(num);
        }

        static void PrintNumber(int num)
        {
            int sum1 = 1;
            int sum2 = 0;
            int sum3 = 0;
            int number = 0;

            for (int i = 1; i <= num; i++)
            {
                number = sum1 + sum2 + sum3;
                Console.Write(number + " ");
                if (i == 1)
                {
                    sum1 = 0;
                    sum2 = 0;
                    sum3 = number;
                }
                else
                {
                    sum1 = sum2;
                    sum2 = sum3;
                    sum3 = number;
                }
            }
        }
    }
}
