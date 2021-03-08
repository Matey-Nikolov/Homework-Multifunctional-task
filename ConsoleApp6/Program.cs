using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); // Тук се пише първоначалната дума - инициализираме.

            while (word != "done") // Условието ще се изпълнява докато не се въведе "done".
            {
                int wordlenth = word.Length; // Взимам дължината на ASCII стойността. 

                if (wordlenth % 3 == 0) // Логическа проверка дали стойносста се дили без остатък на 3.
                {
                    Console.WriteLine("yes");  // Ако няма остатък, се изписва "yes".
                }
                else
                {
                    Console.WriteLine("no"); // Ако не се получава 0.
                }
                word = Console.ReadLine(); // Въвеждаме нова дума.
            }
            Console.WriteLine("no"); // Когато се напише "done".
        }
    }
}