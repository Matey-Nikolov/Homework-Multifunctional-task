using System;

namespace _1_100
{
    class Program
    {
        static void Main()
        {
            PrintHello(4);  // фактичиски параметър.
          //  PrintHello(7); // аргументи.

            int result = SumNums(1, 4, 7);
            Console.WriteLine(result);


            Console.WriteLine(SumDigits(146));
        }

        static void PrintHello(int count) // формален параметър.
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0} Hello", i);
            }
        }

        static int SumNums(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        static int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
