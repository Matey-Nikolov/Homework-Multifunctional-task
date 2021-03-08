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

                if (usernameLanguagePoints == "exam finished")
                {
                    break;
                }

                string[] spiltUsernameLanguagePoints = usernameLanguagePoints.Split("-");

                string username = spiltUsernameLanguagePoints[0];
                string language = spiltUsernameLanguagePoints[1];
                int points = 0;


                if (language != "banned")
                {
                    points = int.Parse(spiltUsernameLanguagePoints[2]);
                    
                    if (!usernamePoints.ContainsKey(username))
                    {
                        usernamePoints.Add(username, points);
                    }
                }
                else
                {
                    usernamePoints.Remove(username);
                }

                if (!languagePoints.ContainsKey(language))
                {
                    languagePoints.Add(language, 0);
                }
                languagePoints[language]++;


            }

            usernamePoints = usernamePoints
                .OrderByDescending(x => x.Value)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);


            Console.WriteLine("Results:");
            foreach (var item in usernamePoints)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            languagePoints = languagePoints
                .OrderByDescending(y => y.Value)
                .OrderBy(y => y.Key)
                .ToDictionary(y => y.Key, y => y.Value);

            Console.WriteLine("Submissions:");
            foreach (var item in languagePoints)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
        }
    }
}
