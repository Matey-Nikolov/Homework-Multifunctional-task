using System;

namespace _3._Конзолен_междувалутен_конвертор
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();

            double result = 0;
            string a = "BGN";

            if (name == "BGN")
            {
                result = sum;
                a = result;
            }
            else if (name == "USD")
            {
                result = sum * 1.72290;
            }
            else if (name == "EUR")
            {
                result = sum * 1.95583;
            }
            else if (name == "GBP")
            {

            }
        }
    }
}
