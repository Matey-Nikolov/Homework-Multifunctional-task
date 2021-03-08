namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] courseStudents = Console.ReadLine()
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> courseNameRegisteredStudents = new Dictionary<string, List<string>>();

            while (courseStudents[0] != "end")
            {
                string course = courseStudents[0];
                string stuent = courseStudents[1];



                if (!courseNameRegisteredStudents.ContainsKey(course))
                {
                    courseNameRegisteredStudents.Add(course, new List<string>());
                }

                courseNameRegisteredStudents[course].Add(stuent);

                courseStudents = Console.ReadLine()
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            courseNameRegisteredStudents = courseNameRegisteredStudents
                 .OrderByDescending(x => x.Value.Count())
                 .ToDictionary(x => x.Key, x => x.Value);


            foreach (var item1 in courseNameRegisteredStudents)
            {
                Console.WriteLine($"{item1.Key}: {item1.Value.Count()}");

                foreach (var item2 in item1.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}