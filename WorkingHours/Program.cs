﻿using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string week = Console.ReadLine();

            switch (week)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hour >= 10 && hour <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;

            }
        }
    }
}
