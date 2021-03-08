namespace MathPower
{
    using System;

    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPawer(number, power);
            Console.WriteLine(result);
        }

        static double RaiseToPawer(double number, int power)
        {
            double result1 = 0;
            result1 = Math.Pow(number, power);
            return result1;
        }
    }
}
