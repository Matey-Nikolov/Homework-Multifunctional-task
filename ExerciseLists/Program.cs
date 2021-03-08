namespace ExerciseLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = "";


            while ((input = Console.ReadLine()) != "end")
            {
                string[] split = input.Split();
                int numWagons = wagons.Count;


                if (split.Length == 1)
                {
                    for (int i = 0; i < numWagons; i++)
                    {
                        int newPassengers = int.Parse(split[0]);

                        if (newPassengers + wagons[i] <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }
                else // ТУК
                {
                    wagons.Add(int.Parse(split[1]));
                    numWagons++;
                }


            }

            Console.WriteLine(string.Join((' '), wagons));
        }
    }
}
