using System;

namespace nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double average = 0;

            int test = 0;
            double test1 = 0;

            double rating = 0;
            double rating1 = 0;

            while (text != "Finish")
            {

                for (int i = 0; i < n; i++)
                {
                    rating = double.Parse(Console.ReadLine());
                    average = rating + average;
                    test++;
                    test1 = rating + test1;
                    rating1++;
                }

                if (test == n)
                {
                    average = average / n;
                    Console.WriteLine($"{text} - {average:f2}.");
                    test = 0;
                    average = 0;
                }
                text = Console.ReadLine();
            }
            test1 = test1 / rating1;
            Console.WriteLine($"Student's final assessment is {test1:f2}.");
        }
    }
}
