using System;

namespace _02._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int bookCounter = 0;
            bool found = false;

            while (bookCounter <= n)
            {
                string input = Console.ReadLine();

                if (input == book)
                {
                    found = true;
                    break;
                }
                bookCounter++;
            }

            if (found)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {n} books.");
            }
        }
    }
}
