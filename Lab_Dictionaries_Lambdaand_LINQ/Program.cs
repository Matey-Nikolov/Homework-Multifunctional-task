namespace Lab_Dictionaries_Lambdaand_LINQ
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
                Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3) // вземими три числа, започва от 0 индекс.
                .ToList()
                .ForEach(el => Console.Write($"{el} "));
        }
    }
}
