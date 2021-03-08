namespace ExerciseArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            foreach (int wagon in wagons) // var - типа променлива. Използва се само за колекчия.
            {
                Console.Write(wagon + " ");
            }
            Console.WriteLine();
            Console.WriteLine(wagons.Sum());
        }
    }
}
