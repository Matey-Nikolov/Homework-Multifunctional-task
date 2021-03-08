namespace Articles_2_0_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Article_2_0> article_s = new List<Article_2_0>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articles = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articles[0];
                string content = articles[1];
                string author = articles[2];

                article_s.Add(new Article_2_0()
                {
                    Title = title,
                    Content = content,
                    Author = author
                });
            }
            string command = Console.ReadLine();

            if (command == "title")
            {
                foreach (Article_2_0 title in article_s.OrderBy(x => x.Title))
                {
                    Console.WriteLine(title.ToString());
                }
            }
            else if (command == "content")
            {
                foreach (Article_2_0 content in article_s.OrderBy(x => x.Content))
                {
                    Console.WriteLine(content.ToString());
                }
            }
            else
            {
                foreach (Article_2_0 author in article_s.OrderBy(x => x.Author))
                {
                    Console.WriteLine(author.ToString());
                }
            }
        }
    }
}