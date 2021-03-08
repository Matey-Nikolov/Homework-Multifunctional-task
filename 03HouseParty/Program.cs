namespace _03HouseParty
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<string> partry = new List<string>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] namePeopleYesNo = Console.ReadLine()
                    .Split(" ");

                if (namePeopleYesNo[2] == "not")
                {
                    if (!partry.Contains(namePeopleYesNo[0]))
                        Console.WriteLine($"{namePeopleYesNo[0]} is not in the list!");
                    else
                        partry.Remove(namePeopleYesNo[0]);
                }
                else if (namePeopleYesNo[1] == "is")
                {
                    if (partry.Contains(namePeopleYesNo[0]))
                        Console.WriteLine($"{namePeopleYesNo[0]} is already in the list!");
                    else
                        partry.Add(namePeopleYesNo[0]);
                }

            }
            foreach (var item in partry)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
