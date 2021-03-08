using System;
using System.Collections.Generic;
using System.Text;

namespace Char_String_Mega
{
    class _10_ExtractText
    {
        public  List<string> Extracts()
        {
            // 10
            //
            Console.Write("Enter a sentence through '.': ");
            string[] sentence = Console.ReadLine()
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            List<string> sentence1 = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                int index = sentence[i].IndexOf(" " + word + " ");

                if (index != -1)
                {
                    sentence1.Add(sentence[i]);
                }
            }
            return sentence1;
        }
    }
}