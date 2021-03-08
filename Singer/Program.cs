using System;
using System.Collections.Generic;

namespace Singer
{
    class Program
    {
        static void Main()
        {
            List<Singer> singers = new List<Singer>();

            while (true)
            {
                string[] a = Console.ReadLine().Split('/');

                string name = a[0];

                if (name == "end")
                    break;

                string name1 = a[1];
                int age = int.Parse(a[2]);
                int fans = int.Parse(a[3]);
                string song = a[4];
                string con = a[5];

                singers.Add(new Singer()
                {
                    NameFirst = name,
                    NameLast = name1,
                    Age = age,
                    Fans = fans,
                    Song = song,
                    Concert = con
                });
            }

            string b = Console.ReadLine();

            switch (b)
            {
                case "showInfo":
                    foreach (Singer item in singers)
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                case "createSong":
                    foreach (Singer item in singers)
                    {
                        Console.WriteLine(item.CreateSong());
                    }
                    break;
                case "playConcert":
                    foreach (Singer item in singers)
                    {
                        Console.WriteLine(item.PlayConcert());
                    }
                    break;

            }
        }
    }
}
