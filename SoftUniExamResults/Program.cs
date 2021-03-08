namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> usernamePoints = new Dictionary<string, int>();
            Dictionary<string, int> languagePoints = new Dictionary<string, int>();

            while (true)
            {
                string usernameLanguagePoints = Console.ReadLine();

                string[] spiltUsernameLanguagePoints = usernameLanguagePoints.Split('-');

                string username = spiltUsernameLanguagePoints[0];
                string language = spiltUsernameLanguagePoints[1];
                int points = 0;

                if (username == "exam" && language == "finished")
                {
                    break;
                }

                if (language != "banned")
                {
                     points = int.Parse(spiltUsernameLanguagePoints[2]);
                }
                else
                {
                    usernamePoints.Remove(username);
                }

                if (!usernamePoints.ContainsKey(username))
                {
                    usernamePoints.Add(username, points);
                    
                    if (!languagePoints.ContainsKey(language))
                    {
                        languagePoints.Add(language, 0);
                    }
                    languagePoints[language]++;
                }
                else
                {
                }
            }

            foreach (var item in usernamePoints)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            foreach (var item in languagePoints)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
        }
    }
}
