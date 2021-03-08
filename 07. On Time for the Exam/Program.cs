using System;

namespace _07._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourtest = int.Parse(Console.ReadLine());
            int mintest = int.Parse(Console.ReadLine());

            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int timetest = hourtest * 60 + mintest;
            int time = hour * 60 + min;

         //   Console.WriteLine(timetest);
         //   Console.WriteLine(time);



            if (((timetest - time) <= 30) && ((timetest - time) >= 0))
            {
                Console.WriteLine("On time");
                if (((timetest - time) <= 30)  && (timetest - time) > 0) 
                {
                    Console.WriteLine($"{timetest - time} minutes before the start");
                }
            }
            else if (time < (timetest - 30))
            {
                Console.WriteLine("Early");
                if ((timetest - time) < 60)
                {
                    Console.WriteLine($"{timetest - time} minutes before the start");
                }
                else
                {
                    if (((timetest - time) % 60) < 10)
                    {
                        Console.WriteLine($"{(timetest - time) / 60}:0{(timetest - time) % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(timetest - time) / 60}:{(timetest - time) % 60} hours before the start");
                    }
                }


            }
            else
            {
                Console.WriteLine("Late");
                if ((time - timetest) < 60)
                {
                    Console.WriteLine($"{time - timetest} minutes after the start");
                }
                else
                {
                    if (((time - timetest) % 60) < 10)
                    {
                        Console.WriteLine($"{(time - timetest) / 60}:0{(time - timetest) % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(time - timetest) / 60}:{(time - timetest) % 60} hours after the start");
                    }
                }

            }

        }
    }
}

