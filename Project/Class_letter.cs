﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Class_letter
    {
        
        public static void lettersSort()
        {
            // 22
            //

            Console.Write("Enter words: ");
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //char[] words = char.ConvertToUtf32(Console.ReadLine());


            Dictionary<char, int> kvp = new Dictionary<char, int>();

            foreach (var item in words)
            {
                foreach (char ch in item)
                {
                    if (!kvp.ContainsKey(ch))
                        kvp.Add(ch, 1);
                    else
                        kvp[ch]++;
                }
            }

            Console.WriteLine("All letters and how many times they occur.");
            foreach (var item in kvp
                .OrderByDescending(x => x.Key))
                Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}