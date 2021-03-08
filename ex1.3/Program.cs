namespace ex1._3
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            
            List<int> numbers = new List<int>();

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == -1)
                {
                    numbers.Sort();
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                numbers.Add(n);
            }
            
        }
    }
}
