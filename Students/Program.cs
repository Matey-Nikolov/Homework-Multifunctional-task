using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] NameAgeAndCity = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    

                string firstName = NameAgeAndCity[0];

                if (firstName == "end")
                {
                    break;
                }

                string lastName = NameAgeAndCity[1];
                int age = int.Parse(NameAgeAndCity[2]);
                string city1 = NameAgeAndCity[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = city1
                };

                students.Add(student);
            }

            string city2 = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city2)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
}
