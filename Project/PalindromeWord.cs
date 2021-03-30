using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class PalindromeWord
    {
        public List<string> Palindromes()
        {
            List<string> palindromWords = new List<string>();
            string palindromWord = "";
            
            while (palindromWord != "end")
            {
                Console.Write("Enter a one word (aaa) while enter a \"end\": ");
                palindromWord = Console.ReadLine();

                int lengthWord = palindromWord.Length;

                string wordReverse = "";

                for (int i = lengthWord; i > 0; i--)
                {
                    wordReverse += palindromWord[i - 1];
                }

                if (palindromWord == wordReverse)
                {
                    palindromWords.Add(palindromWord);
                }
            }
            return palindromWords;
        }
        
    }
}
