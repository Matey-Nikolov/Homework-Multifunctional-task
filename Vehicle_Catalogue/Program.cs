using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                string[] TypeBrandModelPoweroOrWeight = Console.ReadLine()
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = TypeBrandModelPoweroOrWeight[0];

                if (type == "end")
                    break;

                string brand = TypeBrandModelPoweroOrWeight[1];
                string model = TypeBrandModelPoweroOrWeight[2];
                int horsePowerOrWeight = int.Parse(TypeBrandModelPoweroOrWeight[3]);

                if (type == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePowerOrWeight
                    });
                }
                else
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horsePowerOrWeight
                    });
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car catalog1 in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{catalog1.Brand}: {catalog1.Model} - {catalog1.HorsePower}hp");
                }

            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}