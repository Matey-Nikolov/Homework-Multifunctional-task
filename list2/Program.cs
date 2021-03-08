namespace list2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(25);
            numbers.Add(30); // Това маха.
            numbers.Add(4);
            numbers.Add(35);

           // numbers = numbers.Select(n => n * 10).ToList();
           // Console.WriteLine(string.Join(", ", numbers));
            
            
        }
    }
}
