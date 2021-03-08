namespace TEST2021MORE1_9
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers1 = Console.ReadLine().Split("").Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split("").Select(int.Parse).ToList();


            Console.WriteLine(FalseTrue(numbers1, numbers2));
        }

        static string FalseTrue(List<int> numbers1, List<int> numbers2)
        {
            if (numbers1.Count < numbers2.Count)
            {
                int temp = numbers1.Count;
                numbers2 = numbers1;
                temp = numbers2.Count;
            }

            string yes = "Edantic";
            string no = "No";

            for (int i = 0; i < numbers1.Count; i++)
            {
                if (numbers1[i] != ' ')
                {
                    if (numbers1[i] != numbers2[i])
                    {
                        return no;
                    }
                }
            }

            return yes;
        }
    }
}
