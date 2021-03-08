using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double couter = 1;
            double sum = 0;

            while (couter <= 12)
            {
                double assessment = double.Parse(Console.ReadLine());

                if (assessment >= 4.00)
                {
                    sum = sum + assessment;
                    couter++;
                }
            }
            double averege = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averege:f2}");

        }
    }
}
