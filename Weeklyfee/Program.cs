using System;

namespace Weeklyfee
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagesecondjob = int.Parse(Console.ReadLine());
            int workdaysfirstjob = int.Parse(Console.ReadLine());

            double workwage = 0;
            double workwage1 = 0;
            int a = 0;

            wagesecondjob = wagesecondjob * 3;
            workwage = workdaysfirstjob * 60;

            if (workdaysfirstjob >= 3 && workdaysfirstjob <= 7)
            {
                for (int i = 0; i < workdaysfirstjob; i++)
                {
                    string week = Console.ReadLine();

                    switch (week)
                    {
                       case "Friday":
                    // case "Sunday":
                            workwage1 = workwage1 + 60 * 0.15;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{workdaysfirstjob} is invalid number.");
                a++;
            }

            if (a != 1)
            {
                workwage = workwage + wagesecondjob + workwage1;
                Console.WriteLine($"{workwage:f2}");
            }
            
        }
    }
}
