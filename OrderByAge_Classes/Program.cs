using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge_Classes
{
    class Program
    {
        static void Main()
        {
            List<PersonAge> personAges = new List<PersonAge>();

            while (true)
            {
                string[] nameIdAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameIdAge[0];

                if (name == "End")
                {
                    break;
                }

                string id = nameIdAge[1];
                int age = int.Parse(nameIdAge[2]);

                personAges.Add(new PersonAge()
                {
                    Name = name,
                    Id = id,
                    Age = age
                });
            }

            foreach (PersonAge item in personAges.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}