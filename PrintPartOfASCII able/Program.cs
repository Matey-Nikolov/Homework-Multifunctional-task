
namespace PrintPartOfASCIITable
{
    using System;

    class Program
    {
        static void Main()
        {
            int startIndext = int.Parse(Console.ReadLine());
            int endIndext = int.Parse(Console.ReadLine());

            PrintASCIITable(startIndext, endIndext);
        }

        static void PrintASCIITable(int startIndext, int endIndext)
        {
            for (int i = startIndext; i <= endIndext; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
