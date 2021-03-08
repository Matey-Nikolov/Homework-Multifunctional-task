using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Char_String_Mega
{
    class PalindromeWord
    {
        public List<string> Palindromes()
        {
            // 21
            //
            //
            Console.Write("Enter a words by ',' : ");
            List<string> text = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> palindsWords = new List<string>();

            foreach (string str in text)
            {
                string reverse = "";

                for (int i = str.Length; i > 0; i--)
                {
                    reverse += str[i - 1];
                }

                if (reverse == str)
                {
                    palindsWords.Add(reverse);
                }
            }
            return palindsWords;
        }
    }
}