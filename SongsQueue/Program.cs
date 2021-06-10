namespace SongsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<string> songs = new Queue<string>();

            string[] textSong = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < textSong.Length; i++)
            {
                string startSongs = textSong[i];
                if (!songs.Contains(startSongs))
                    songs.Enqueue(startSongs);
            }


            while (true)
            {
                string playAddShowOrSongs = Console.ReadLine();


                int index = playAddShowOrSongs.IndexOf(" ");
                string command = "";
                string newSongs = "";

                if (index != -1)
                {
                    command = playAddShowOrSongs.Substring(0, index);
                    playAddShowOrSongs = playAddShowOrSongs.Remove(0, index + 1);
                    newSongs = playAddShowOrSongs;
                }
                else
                {
                    command = playAddShowOrSongs;
                }

                switch (command)
                {
                    case "Play":
                        if (songs.Count > 1)
                        {
                            songs.Dequeue();
                        }
                        else
                        {
                            songs.Dequeue();
                            Console.WriteLine("No more songs!");
                            return;
                        }
                        break;
                    case "Add":
                        if (!songs.Contains(newSongs))
                            songs.Enqueue(newSongs);
                        else
                        Console.WriteLine($"{newSongs} is already contained!");
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
        }
    }
}