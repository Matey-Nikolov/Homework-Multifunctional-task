using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double couter = 1;
            double sum = 0;

            int couter1 = 0;
            bool a = false;

            while (couter <= 12)
            {
                double assessment = double.Parse(Console.ReadLine());

                if (assessment < 4.00)
                {
                    couter1++;
                    
                    if (couter1 == 2)
                    {
                        a = true;
                        break;
                    }
                }

                if (assessment >= 4.00)
                {
                    sum = sum + assessment;
                    couter++;
                }
            }

            if (a == true)
            {
                Console.WriteLine($"{name} has been excluded at {couter} grade");
            }
            else
            {
                double averege = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averege:f2}");

            }
        }
    }
}
