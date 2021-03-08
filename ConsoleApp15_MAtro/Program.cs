using System;
using System.Text;

namespace ConsoleApp15_MAtro
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder(100);
            builder.Append("Hello Maria, how are you?");
            Console.WriteLine(builder); // Hello Maria, how are you?
            builder[6] = 'D';
            Console.WriteLine(builder); // Hello Daria, how are you?
            builder.Remove(5, 6);
            Console.WriteLine(builder); // Hello, how are you?
            builder.Insert(5, " Peter");
            Console.WriteLine(builder); // Hello Peter, how are you?
            builder.Replace("Peter", "George");
            Console.WriteLine(builder); // Hello George, how are you?
        }
    }
}
