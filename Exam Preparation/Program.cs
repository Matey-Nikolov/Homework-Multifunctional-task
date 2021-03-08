using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryratings = int.Parse(Console.ReadLine());

            int couter = 0;

            double numcouter = 0;
            double numassessment = 0;

            int numberoftask = 0;

            string lasttask = "";

            while (couter <= unsatisfactoryratings)
            {
                string task = Console.ReadLine();

                if (task == "Enough")
                {
                    numassessment = numassessment / numcouter;

                    Console.WriteLine($"Average score: {numassessment:F2}");
                    Console.WriteLine($"Number of problems: {numberoftask}");
                    Console.WriteLine($"Last problem: {lasttask}");
                    break;
                }

                int assessment = int.Parse(Console.ReadLine());

                numassessment = numassessment + assessment;

                if (assessment <= 4)
                {
                    couter++;
                }

                if (couter == unsatisfactoryratings)
                {
                    Console.WriteLine($"You need a break, {couter} poor grades.");
                    break;
                }

                numberoftask++;
                numcouter++;
                lasttask = task;
            }

        }
    }
}
