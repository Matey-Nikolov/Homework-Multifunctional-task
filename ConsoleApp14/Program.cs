namespace ConsoleApp14
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] alpha2 = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


                string abc = Console.ReadLine();

            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < alpha2.Length; j++)
                {
                    if (abc[i] == alpha2[j])
                    {
                        Console.WriteLine($"{abc[i]} -> {j}");
                    }
                }
            }
        }
    }
}
