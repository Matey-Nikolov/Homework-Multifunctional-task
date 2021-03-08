using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            String name2 = Console.ReadLine();

           
            
            if(name == name2)
            {
                Console.WriteLine($"{num: f8}");

            }

            if (name == "km" && name2 == "ft")
            {
                num = num * 0.0003048;
                Console.WriteLine($"{num: f8}");
            }
            else if (name == "ft" && name2 == "mm")
            {
                num = num * 304.8;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "mi" && name2 == "in")
            {
                num = num * 63360;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "yd" && name2 == "km")
            {
                num = num * 0.0009144;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "cm" && name2 == "yd")
            {
                num = num * 0.010936133;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "m" && name2 == "mm")
            {
                num = num * 1000;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "m" && name2 == "cm")
            {
                num = num * 100;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "m" && name2 == "mi")
            {
                num = num * 0.000621371192;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "m" && name2 == "in")
            {
                num = num * 39.3700787;
                Console.WriteLine($"{num:f8}");
            }
            else if (name == "m" && name2 == "km")
            {
                num = num * 0.001;
                Console.WriteLine($"{num:f8}");
            }
        }
    }
}
