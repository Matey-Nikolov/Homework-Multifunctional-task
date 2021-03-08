using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num2 = 0;

            if (num <= 100)
            {
                num2 += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                num2 = num * 0.2;
            }
            else if (num > 1000)
            {
                num2 = num * 0.1;
            }


            if (num % 2 == 0)
            {
                num2 = num2 + 1;
            }
            else if (num % 10 == 5)
            {
                num2 = num2 + 2;
            }

            Console.WriteLine(num2);
            Console.WriteLine(num + num2);


        }
    }
}
