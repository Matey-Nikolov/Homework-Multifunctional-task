using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double evaluation = 0;

            switch (country)
            {
                case "Russia":
                    switch (device)
                    {
                        case "ribbon":
                            evaluation = 9.100 + 9.400;
                            break;
                        case "hoop":
                            evaluation = 9.300 + 9.800;
                            break;
                        case "rope":
                            evaluation = 9.600 + 9.000;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (device)
                    {
                        case "ribbon":
                            evaluation = 9.600 + 9.400;
                            break;
                        case "hoop":
                            evaluation = 9.550 + 9.750;
                            break;
                        case "rope":
                            evaluation = 9.500 + 9.400;
                            break;
                    }
                    break;

                case "Italy":
                    switch (device)
                    {
                        case "ribbon":
                            evaluation = 9.200 + 9.500;
                            break;
                        case "hoop":
                            evaluation = 9.450 + 9.350;
                            break;
                        case "rope":
                            evaluation = 9.700 + 9.150;
                            break;
                    }
                    break;
            }

            double remains = 20 - evaluation;
            double pointtothemaximum = remains / 20 * 100;

            Console.WriteLine($"The team of {country} get {evaluation:f3} on {device}.");
            Console.WriteLine($"{pointtothemaximum:f2}%");
        }
    }
}
