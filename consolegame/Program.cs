using System;

namespace consolegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            String name1;

            if (name == 1234)
            {
                Console.WriteLine("Welcome");
                Console.Write("Plese enter name ");
                name1 = Console.ReadLine();
                
                if (name1 = "Mat")
                {
                    Console.WriteLine("Очаквах те ");
                }
                else
                {
                    return;

                }
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
            
        }
    }
}
