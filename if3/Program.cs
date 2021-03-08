using System;

namespace if3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Great nember:{num1}");
            }
            else
            {
                Console.WriteLine($"Great nember:{num2}");
            }
          

        }
    }
}
