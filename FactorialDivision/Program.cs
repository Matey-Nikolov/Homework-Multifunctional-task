
namespace FactorialDivision
{
    using System;

    class Program
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double a = PrintFactorialDivision(number1, number2);
            Console.WriteLine($"{a:f2}");
        }

        static double PrintFactorialDivision(double number1, double number2)
        {
            double factorialFirst = 1;
            double factorialsecond = 1;

            if (number1 > 0 && number2 > 0)
            {

                for (int i = 1; i <= number1; i++)
                {
                    factorialFirst *= i;
                }

                for (int a = 1; a <= number2; a++)
                {
                    factorialsecond *= a;
                    // Console.WriteLine(factorialsecond);
                }
            }

            double factorialSum = factorialFirst / factorialsecond;
            return factorialSum;
        }
    }
}
