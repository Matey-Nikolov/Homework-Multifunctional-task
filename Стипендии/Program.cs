using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {

            double dohod = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double social = salary * 0.35;
            double scholar = score * 25;
          
            if (dohod < salary && score > 4.50)
            {
                if (score >= 5.50 && social < scholar)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholar)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                }
            }
            else if (score >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholar)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}