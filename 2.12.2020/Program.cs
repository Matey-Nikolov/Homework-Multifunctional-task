namespace _2._12._2020
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        }

        // A ex 9
        static void BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                int b;
                for (int j = 0; i < n - i - 1; i++)
                {
                    if (list[i] < list[j + 1]) 
                    {
                        b = list[i];
                        list[i] = list[i + 1];
                        b = list[i + 1];
                    }
                }
            }
        }

        // A ex 10
        static List<int> GetNumbersFromArray(string[] array)
        {
            int currentParseElement;
            List<int> numbers = new List<int>();
            foreach (var element in array)
            {
                if (Int32.TryParse(element, out currentParseElement))
                {
                    numbers.Add(currentParseElement);
                }
            }
            return numbers;
        }

    }
}
