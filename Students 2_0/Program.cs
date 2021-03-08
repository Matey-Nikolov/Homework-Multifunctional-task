using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2_0
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

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);


                if (student == null) //IsStudentExisting(students, firstName, lastName)
                {
                    //Student student = GetStudent(students, firstName, lastName);

                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = city1
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = city1;
                }
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
        /*
        static bool IsStudentExisting(List<Student> students, string firstName, string LastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == LastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
        */
    }
}
