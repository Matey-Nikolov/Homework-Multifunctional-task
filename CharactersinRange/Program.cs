
namespace CharactersinRange
{
    using System;

    class Program
    {
        static void Main()
        {
            char frist = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintCharacters(frist, second);
        }

        static void PrintCharacters(char frist, char second)
        {

            if (frist < second)
            {
                for (int i = frist + 1; i < second; i++)
                {
                    char print = Convert.ToChar(i);
                    Console.Write($"{print} ");
                }
            }
            else
            {
                for (int i = second + 1; i < frist; i++)
                {
                    char print = Convert.ToChar(i);
                    Console.Write($"{print} ");
                }
            }
        }
    }
}
