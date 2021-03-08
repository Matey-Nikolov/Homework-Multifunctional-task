
namespace SpecialNumbers_lab
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSpecialNumbers(n);
        }

        static void PrintSpecialNumbers(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                int sumDigits = 0;
                int digits = i;

                while (digits != 0)
                {
                    sumDigits += digits % 10;
                    digits = digits / 10;
                }

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                   // sumDigits = 0;
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                  //  sumDigits = 0;
                }
            }
        }
    }
}
