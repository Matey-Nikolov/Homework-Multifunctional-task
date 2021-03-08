using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class SortWord_25
    {

        public string[] ReturnWordSort()
        {
            Console.Write("Enter a words ', ': ");
            string[] arrayWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            SelectionSort(arrayWords);
            return arrayWords;
        }

        public static void SelectionSort(string[] arrWord)
        {
            int n = arrWord.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    int result = string.Compare(arrWord[j], arrWord[min]);

                    if (result < 0)
                    {
                        min = j;
                    }
                }



                string temp = arrWord[min];
                arrWord[min] = arrWord[i];
                arrWord[i] = temp;
            }

        }
    }
}