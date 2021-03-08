namespace CompanyUsers2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitCommnds = command.Split(" -> ");

                string companyName = splitCommnds[0];
                string emloyeeId = splitCommnds[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>() { emloyeeId });
                }
                else if (!companies[companyName].Contains(emloyeeId))
                {
                    companies[companyName].Add(emloyeeId);
                }

                command = Console.ReadLine();
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
