using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Students_clases
{
    class Program
    {
        static void Main()
        {
            List<Students> students = new List<Students>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] oneStudent = Console.ReadLine()
                    .Split(" ");

                string firstName = oneStudent[0];
                string secondName = oneStudent[1];
                double grade = double.Parse(oneStudent[2]);

                students.Add(new Students()
                {
                    FirstName = firstName,
                    LastName = secondName,
                    Grade = grade
                });
            }

            foreach (Students students1 in students
                .OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{students1.FirstName} {students1.LastName}: {students1.Grade:f2}");
            }
        }
    }
}
