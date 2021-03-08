namespace RecursiveFibonacci
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine()); // 5

            long[] fibonacci = new long[num];
            fibonacci[0] = 1;


            if (1 <= num && num <= 50)
            {
                if (num > 1)
                {
                    fibonacci[1] = 1;
                }

                for (int i = 2; i < num; i++)
                {
                    // 1
                    // 1
                    // (i - 2) 2 = 1 + 1;
                    // (i - 3) 3 = 2 + 1;
                    // (i - 4) 5 = 3 + 2;
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.WriteLine(fibonacci[fibonacci.Length - 1]);
            }
            else
            {
                return;
            }
        }

        /*
        static int GetFibonacci(int num1, ref int num2)
        {
            if (num1 == 1 || num2 == 10)
            {
                return 1;
            }

            num2++;

            return GetFibonacci(num1 - 1, ref num2) + GetFibonacci(num1 - 2, ref num2);
        }
        */
    }
}
