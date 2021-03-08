using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee_Statistic
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            int linesOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesOfEmployees; i++)
            {
                string[] nameSalaryDepartment = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameSalaryDepartment[0];
                float salary = float.Parse(nameSalaryDepartment[1]);
                string department = nameSalaryDepartment[2];

                employees.Add(new Employee()
                {
                    Name = name,
                    ASalary = salary,
                    Department = department
                });
            }

            List<Employee> tmp = new List<Employee>();
            tmp = employees.OrderByDescending(x => x.ASalary).ToList();

            Dictionary<string, List<float>> kvp = new Dictionary<string, List<float>>();

            for (int i = 0; i < tmp.Count; i++)
            {
                string newDepartment = tmp[i].Department;
                float newSlary = tmp[i].ASalary;

                if (!kvp.ContainsKey(newDepartment))
                {
                    kvp[newDepartment] = new List<float>();
                }
                kvp[newDepartment].Add(newSlary);
            }

            string maxSalary = kvp.OrderByDescending(x => x.Value.Average()).First().Key;

            /*
            Dictionary<string, float> departments = new Dictionary<string, float>();

            foreach (var item in employees)
            {
                if (!departments.ContainsKey(item.Department))
                {
                    departments.Add(item.Department, item.ASalary);
                }
                else
                {
                    float tmp = departments.GetValueOrDefault(item.Department);
                    departments[item.Department] = (item.ASalary + tmp) / 2;
                }
            }

            string maxDepSalary = departments
                                        .OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine($"Highest Average Salary: {maxDepSalary}");

            foreach (var employee1 in employees.Where(x => x.Department == maxDepSalary).OrderByDescending(x => x.ASalary))
            {
                Console.WriteLine($"{employee1.Name} {employee1.ASalary:f2}");
            }
            */

            Console.WriteLine($"Highest Average Salary: {maxSalary}");

            foreach (Employee item in employees
                .Where(x => x.Department == maxSalary)
                .OrderByDescending(x => x.ASalary))
            {
                Console.WriteLine($"{item.Name} {item.ASalary:f2}");
            }
        }
    }
}