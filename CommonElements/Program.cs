namespace CommonElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] arrays1 = Console.ReadLine()
                                      .Split();

            string[] arrays2 = Console.ReadLine()
                                      .Split();

            string[] result = arrays2
                .Intersect(arrays1)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));            
        }
    }
}
