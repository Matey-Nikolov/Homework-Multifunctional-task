namespace StudentAcademy2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }
                students[studentName].Add(grade);
            }

                students = students
                    .Where(st => st.Value.Average() >= 4.50)
                    .OrderByDescending(st => st.Value.Average())
                    .ToDictionary(st => st.Key, st => st.Value);
            
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
