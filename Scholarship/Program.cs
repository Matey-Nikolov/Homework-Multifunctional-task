using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {

            double lv = double.Parse(Console.ReadLine());
            double averagesuccess = double.Parse(Console.ReadLine());
            double minimalsalary = double.Parse(Console.ReadLine());

            double socialscholarship = minimalsalary * 0.35;
            double scholarshipforexcellence = averagesuccess * 25;

            if (lv < minimalsalary && averagesuccess > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialscholarship)} BGN");
            }
            else if (averagesuccess >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipforexcellence)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}