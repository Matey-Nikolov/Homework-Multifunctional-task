using System;

namespace масив_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 3, 4, 34, 54 };
            foreach(int val in arr)
            {
                Console.WriteLine(val);
            }

            string[] names = { "Stavri", "Stamat", "Pesho" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
