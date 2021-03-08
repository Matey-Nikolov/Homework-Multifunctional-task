using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class ClassWord_15
    {
        public string DictionaryOfWords()
        {
            // 15
            //

            Dictionary<string, string> dictionaryPrograming = new Dictionary<string, string>();
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter words with their meaning with '-': ");
                string[] name = Console.ReadLine()
                    .Split("-");

                string word = name[0];
                string explanation = name[1];

                if (!dictionaryPrograming.ContainsKey(word))
                    dictionaryPrograming.Add(word, explanation);
            }
            Console.Write("Enter a word you want to understand the meaning: ");
            string word1 = Console.ReadLine();

            foreach (var item in dictionaryPrograming)
            {
                if (item.Key.Contains(word1))
                    return $"{item.Key} - {item.Value}";
            }
            return "There's no such word.";
        }

    }
}
