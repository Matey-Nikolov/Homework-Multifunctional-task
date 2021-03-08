namespace LabDataTypesandVariables
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintConvert(number);
        }

        static void PrintConvert(double number)
        {
            number = number / 1000.0;
            Console.WriteLine($"{number:f2}");
        }
    }
}
