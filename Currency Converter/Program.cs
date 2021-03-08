using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double result = 0;

            if (inputCurrency == "BGN" && outputCurrency == "BGN")
            {
                Console.WriteLine($"{result:f2} BGN");
            }

            if (outputCurrency == "USD")
            {
                result = money / 1.79549;
                Console.WriteLine($"{result:f2} USD");
            }
            else if (outputCurrency == "EUR")
            {
                result = money / 1.95583;
                Console.WriteLine($"{result:f2} EUR");
            }
            else if (outputCurrency == "GBP")
            {
                result = money / 2.53405;
                Console.WriteLine($"{result:f2} GBP");
            }

        }
    }
}
