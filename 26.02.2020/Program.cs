using System;

namespace _26._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();

            if (name == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!"); 
            }

           
        }
    }
}
