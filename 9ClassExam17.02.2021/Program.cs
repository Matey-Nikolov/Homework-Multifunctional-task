namespace _9ClassExam17._02._2021
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            int countOfEmployeesN = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfEmployeesN; i++)
            {
                string[] firstLastSalary = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = firstLastSalary[0];
                string lastName = firstLastSalary[1];
                float salary = float.Parse(firstLastSalary[2]);

                employees.Add(new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Salary = salary
                });
            }

            foreach (Employee employee in employees
                .OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary:f2}");
            }
        }
    }
}
