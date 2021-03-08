namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                    words.Add(word, new List<string>());

                words[word].Add(synonym);
            }
                Console.WriteLine($"{words.Keys} - {words.Values}, ");
            
        }
    }
}
