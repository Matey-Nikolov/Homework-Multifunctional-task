using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age_Classes
{
    class Program
    {
        static void Main()
        {
            List<Order_by_Age> person = new List<Order_by_Age>();

            while (true)
            {
                string[] nameIdAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameIdAge[0];

                if (name == "End")
                    break;

                string iD = nameIdAge[1];
                int age = int.Parse(nameIdAge[2]);

                person.Add(new Order_by_Age()
                {
                    NamePerson = name,
                    ID = iD,
                    Age = age
                });
            }

            foreach (Order_by_Age onePerson in person
                .OrderBy(age => age.Age))
            {
                Console.WriteLine($"{onePerson.NamePerson} with ID: {onePerson.ID} is {onePerson.Age} years old.");
            }
        }
    }
}
