using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue23_Classes
{
    class Program
    {
        static void Main()
        {
            Catalogue catalogues = new Catalogue();

            while (true)
            {
                string[] b = Console.ReadLine()
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = b[0];

                if (type == "end")
                {
                    break;
                }

                string brand = b[1];
                string model = b[2];
                int horsePowerOrWeight = int.Parse(b[3l]);

                if (type == "Car")
                {
                    catalogues.Cars.Add(new Car2
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePowerOrWeight
                    });
                }
                else
                {
                    catalogues.Trucks.Add(new Truck2
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horsePowerOrWeight
                    });
                }
            }

            if (catalogues.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car2 item in catalogues.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }

            if (catalogues.Trucks.Count > 0)
            {
                Console.WriteLine("Truks:");

                foreach (Truck2 item in catalogues.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }
}