using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            number1 = n % a; // Правя целочислено деление.
                            number2 = n % b;
                            number3 = n % c;
                            number4 = n % d;
                            if (number1 == 0 && number2 == 0 && number3 == 0 && number4 == 0)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
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
