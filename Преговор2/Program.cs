using System;

namespace Преговор2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {

                if (n % 2 == 0)
                {
                    int number = int.Parse(Console.ReadLine());
                    even = even + number;
                }
                else
                {
                    int number2 = int.Parse(Console.ReadLine());
                    odd = odd + number2;
                }
            }

            if (even == odd)
            {
                Console.WriteLine($"Yes, sum = {odd}");
            }
            else if (even != odd)
            {
                int diff = 0;
                diff = odd - even;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");

            }

        }
    }
}