using System;

namespace abc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            int num = 0;
            int num1 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number % 2 == 0 )
                {
                    num = number + num;
                }
                else
                {
                    num1 = number + num1;
                }

                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }

            }

            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
