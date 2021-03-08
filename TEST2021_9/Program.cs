using System;

namespace TEST2021_9
{
    class Program
    {
        static void Main()
        {

            string words1 = Console.ReadLine();
            string words2 = Console.ReadLine();

            Console.WriteLine(Еdantic(words1, words2));
        }

        static string Еdantic(string word1, string word2)
        {
            if (word1.Length < word2.Length)
            {
                string temp = word1;
                word2 = word1;
                temp = word2;
            }

            string yes = "Edantic";
            string no = "No";

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != ' ')
                {
                    if (word1[i] != word2[i])
                    {
                        return no;
                    }
                }
            }

            return yes;
        }
    }
}
