﻿namespace Lab_Strings_and__Text_Processing
{
    using System;

    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string reversed = "";

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }

                Console.WriteLine($"{line} = {reversed}");
                line = Console.ReadLine();
            }
        }
    }
}
