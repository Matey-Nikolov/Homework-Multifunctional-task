namespace StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> stydentAndGrade = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!stydentAndGrade.ContainsKey(name))
                {
                    stydentAndGrade.Add(name, new List<double>());
                }
                stydentAndGrade[name].Add(grade);
            }

            stydentAndGrade = stydentAndGrade
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            
            foreach (var item in stydentAndGrade)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}

