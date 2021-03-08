using System;

namespace nestest_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double average = 0;
            int test = 0;
            double rating = 0;

            while (text != "Finish")
            {

                for (int i = 0; i < n; i++)
                {
                    rating = double.Parse(Console.ReadLine());
                    average = rating + average;
                    test++;
                }

                if (test == n)
                {
                    average = average / n;
                    Console.WriteLine($"{text} - {average}.");
                    test = 0;
                }
                text = Console.ReadLine();
            }

            rating = rating / n;
            Console.WriteLine($"Student's final assessment is {rating}".);
        }
    }
}
