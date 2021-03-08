using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsinthebrowser = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabsinthebrowser; i++)
            {
                string media = Console.ReadLine();

                switch (media)
                {
                    case "Facebook":
                        salary = salary - 150;
                        break;
                    case "Instagram":
                        salary = salary - 100;
                        break;
                    case "Reddit":
                        salary = salary - 50;
                        break;
                    case "Dev.bg":
                    case "Github.com":
                    case "Stackoverflow.com":
                    case "softuni.bg":
                        salary = salary;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
