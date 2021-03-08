namespace Lab_Objects_and__Classes_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] info = Console.ReadLine()
                    .Split('_');

                string type = info[0];
                string name = info[1];
                string time = info[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string songType = Console.ReadLine();

            if (songType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else if (songType == "favourite")
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == songType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            List<Song> result = songs
                .Where(s => s.TypeList == songType)
                .ToList();

            foreach (Song song in result)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}