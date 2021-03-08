namespace ReversedChars
{
    using System;

    class Program
    {
        static void Main()
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            PrintMirror(ch1, ch2, ch3);
        }

        static void PrintMirror(char ch1, char ch2, char ch3)
        {
            Console.WriteLine($"{ch3} {ch2} {ch1}");
        }
    }
}
