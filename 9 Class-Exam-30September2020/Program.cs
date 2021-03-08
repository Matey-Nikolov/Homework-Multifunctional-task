using System;

namespace _9_Class_Exam_30September2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayswork = int.Parse(Console.ReadLine());

            int work = 0;
            int work1 = 0;
            int totaltime = 0;

            if (dayswork >= 3 && dayswork <= 7)
            {
                work = dayswork * 8;
                work1 =  3 * 5;
                totaltime = work + work1;
                Console.WriteLine(totaltime);
            }
            else
            {
                Console.WriteLine($"{dayswork} is invalid number.");
            }
        }
    }
}
