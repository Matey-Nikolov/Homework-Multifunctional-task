using System;

namespace ArrayListDictionary
{
    class Program
    {
        static void Main()
        {
            // Инициализирам си двата масива.
            string[] textArray1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] textArray2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            /*
            int lengthText1 = textArray1.Length;
            int lengthText2 = textArray2.Length;
            
            for (int i = 0; i < lengthText1 - 1; i++)
            {
                for (int a = 0; a < lengthText2 - 1; a++)
                {
                    if (textArray1[i] == textArray2[a])
                    {
                        Console.WriteLine(textArray1[i]);
                    }
                }
            }
            */
            // Вместо с for го направих с foreach.
            foreach (string word2 in textArray2)
            {
                foreach (string word1 in textArray1)
                {
                    // Проверяме от единия масив(textArray2) дали съвпадат елементи от другия масив(textArray1).
                    if (word1 == word2)
                    {
                        // Ако съвпадата принтираме думата.
                        Console.Write(word2 + " ");
                    }
                }
            }
        }
    }
}
