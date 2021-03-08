using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterbyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("8 - Filter by age");

                int option = 0;

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                        FilterByAge();
                        break;
                }

                Console.ReadLine();
            }
        }

        static void FilterByAge()
        {
            // 8 

            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                nameAge.Add(name, age);
            }

            string olderOrYounder = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());

            switch (olderOrYounder)
            {
                case "older":
                    Older(nameAge, age2);
                    break;
            }
        }

        static void Older(Dictionary<string, int> nameAge, int age2)
        {
            // метод за 8

            nameAge.Where(x => age2 >= x.Value);

            string[] nameAndAge = Console.ReadLine().Split(" ").ToArray();

            if (nameAndAge[0] == "name")
            {
                foreach (var item in nameAge)
                {
                    Console.WriteLine(item.Key);
                }
            }
            else if (nameAndAge[0] == "name" && nameAndAge[0] == "age")
            {
                foreach (var item in nameAge)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
