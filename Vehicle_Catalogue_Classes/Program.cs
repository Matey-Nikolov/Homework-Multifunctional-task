namespace Vehicle_Catalogue_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Catalog> catalog = new List<Catalog>();

            while (true)
            {
                string[] TypeModelColorPowerHorsePower = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = TypeModelColorPowerHorsePower[0];

                if (type == "End")
                    break;

                string model = TypeModelColorPowerHorsePower[1];
                string color = TypeModelColorPowerHorsePower[2];
                double horsePower = double.Parse(TypeModelColorPowerHorsePower[3]);

                catalog.Add(new Catalog()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                });

            }

            while (true)
            {
                string[] modelOfVehicles = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = modelOfVehicles[0];

                if (model == "Close")
                {
                    break;
                }

                foreach (Catalog item in catalog.Where(c => c.Model == model))
                {
                    if (item.Type == "car")
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                    else if (item.Type == "truck")
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
            }

         
            List<Catalog> onlycars = new List<Catalog>();
            onlycars = catalog.FindAll(c => c.Type == "car");

            List<Catalog> onlyTrucks = new List<Catalog>();
            onlyTrucks = catalog.FindAll(c => c.Type == "truck");

            if (onlycars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                double averageCars = onlycars.Sum(s => s.HorsePower) / onlycars.Count;  
                Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            }

            if (onlyTrucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                double averageTrucks = onlyTrucks.Sum(s => s.HorsePower) / onlyTrucks.Count; 
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
            }
        }
    }
}