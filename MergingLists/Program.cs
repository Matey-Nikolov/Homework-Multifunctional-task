namespace MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Min(list1.Count, list2.Count); i++)
            {
                resultList.Add(list1[i]);
                resultList.Add(list2[i]); 
            }

            if (list1.Count > list2.Count)
                resultList.AddRange(ListAdd(list1, list2));
            else if (list2.Count > list1.Count)
                resultList.AddRange(ListAdd(list2, list1));

            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<int> ListAdd(List<int> longNums, List<int> smallSNums)
        {
            List<int> connect = new List<int>();
            for (int i = smallSNums.Count; i < longNums.Count; i++)
                connect.Add(longNums[i]);
            return connect;
        }
    }
}
