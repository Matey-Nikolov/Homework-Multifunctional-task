
namespace ConcatNames
{
    using System;

    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string dimiter = Console.ReadLine();

            string name = ReturnResult(firstName, lastName, dimiter);
            Console.WriteLine(name);
        }

        static string ReturnResult(string firstName, string lastName, string dimiter)
        {
            string stringsum = "";
            return stringsum = $"{firstName}{dimiter}{lastName}";
        }
    }
}
