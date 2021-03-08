namespace list
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
                int num = int.Parse(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }
                numbers.Add(num); // Добавя се елемент открая.
            }
            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
