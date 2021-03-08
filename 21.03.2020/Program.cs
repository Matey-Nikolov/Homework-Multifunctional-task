using System;

namespace _21._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double pricelv = 0;
            double people = 0;
            double lv = 0;

            switch (name)
            {
                case "Premiere":
                    pricelv = 12.00;
                    break;
                case "Normal":
                    pricelv = 7.50;
                    break;
                case "Discount":
                    pricelv = 5.00;
                    break;
            }

            people = r * c;
            lv = people * pricelv;
            Console.WriteLine($"{lv:f2} leva");
        }
    }
}
