using System;

namespace Trainthetrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); 
            string presentation = Console.ReadLine();

            double sum = 0;
            double totalsum = 0;
            double total = 0;
            int a = 0;

            while (presentation != "Finish")
            {
                for (int i = 0; i < people; i++)
                {
                    
                    double rating = double.Parse(Console.ReadLine());
                    sum += rating;
                    totalsum += rating;
                    a++;
                }
                total = sum / people;
                Console.WriteLine($"{presentation} - {total:f2}.");

                sum = 0;
                total = 0;
                presentation = Console.ReadLine();
            }

            totalsum = totalsum / a;
            Console.WriteLine($"Student's final assessment is {totalsum:f2}.");
        }
    }
}
