namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> petrol = new Queue<int>();
            Queue<int> sumDistance = new Queue<int>();

            int countOfPetrolPump = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                int[] amountOfPetrolAndDistance = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int amountOfPetrol = amountOfPetrolAndDistance[0];
                int distance = amountOfPetrolAndDistance[1];



                petrol.Enqueue(amountOfPetrol);
                sumDistance.Enqueue(distance);

                if (petrol.Peek() >= sumDistance.Peek())
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
    }
}