
namespace PoundstoDollars
{
    using System;

    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            PrintConvertBritishPoundsToUS(number);
        }

        static void PrintConvertBritishPoundsToUS(double number)
        {
            number = number * 1.31;
            Console.WriteLine($"{number:f3}");
        }
    }
}
