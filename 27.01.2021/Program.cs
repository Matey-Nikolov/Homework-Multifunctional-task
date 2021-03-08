namespace _27._01._2021
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] token = input.Split(' ');

                string firstName = token[0];
                string lastName = token[1];
                string age = token[2];
                string homeTown = token[3];

                Student existingStudent = students
                    .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (existingStudent == null)
                {

                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = homeTown
                    };

                    students.Add(student);
                }
                else
                {
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.City = homeTown;
                }


                input = Console.ReadLine();
            }

            string TargetCity = Console.ReadLine();

            foreach (Student student1 in students.Where(st => st.City == TargetCity))
            {
                Console.WriteLine($"{student1.FirstName} {student1.LastName} is {student1.Age} years old.");
            }
        }
    }
}