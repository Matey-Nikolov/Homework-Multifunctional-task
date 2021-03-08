using System;

namespace методи
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printnumber(n);
        }

        static void printnumber(int n)
        {
            if (n > 0)  // рекурсия, метод в метода 
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
