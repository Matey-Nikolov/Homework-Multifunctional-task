using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int one = 1; n / one == 1; one++)
            {
                for (int two = 2; n / two == 2 ; two++)
                {
                    Console.WriteLine($"{one}{two}");
                }
            }
        }
    }
}
