namespace FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stack<int> rackClothes = new Stack<int>();

            List<int> numClothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacityOfRack = int.Parse(Console.ReadLine());

            for (int i = 0; i < numClothes.Count; i++)
                rackClothes.Push(numClothes[i]);

            int numberOfRacks = 0;
            int sumNumber = 0;

            for (int numCount = 0; numCount < rackClothes.Count; numCount++)
            {
                int newNumber = rackClothes.Peek();


                if (sumNumber >= capacityOfRack)
                {
                    numberOfRacks++;
                    sumNumber = 0;
                }

                sumNumber += newNumber;

            }

            Console.WriteLine(numberOfRacks);
        }
    }
}