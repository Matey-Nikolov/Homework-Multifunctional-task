using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double number1 = 0;
            double number2 = 0;
            double number3 = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            number1 = a + b;
                            number2 = c + d;
                            number3 = n % (a + b);
                            if (number3 == 0 && number1 == number2)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                //number3 = 0;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
        }
    }
}
