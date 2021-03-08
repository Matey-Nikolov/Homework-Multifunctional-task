using System;

namespace Завършване
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grades = 1;
            double sum = 0;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                sum += grade;
                grades += 1;

                double average = sum / 12;
                if (grade >= 4.00)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                }
            }

        }
    }
}
