namespace list1
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

            numbers.Insert(2, 100);// Конкретен индекс.

            //foreach (var item in numbers)
           // {
           //     Console.WriteLine(item);
           // }

            Console.WriteLine("Min number: {0}", numbers.Min());
            Console.WriteLine("Max number: {0}", numbers.Max());

            Console.WriteLine("Sum: {0}", numbers.Sum());
            Console.WriteLine("Average: {0}", numbers.Average());

            numbers.Reverse();
            Console.WriteLine("Reverse: " + string.Join(", ",numbers));

            numbers.RemoveAll(n => n == 30);
            numbers.Remove(30); // Първото срещнато число.
            numbers.Remove(3); // Маха цялото адд.
            Console.WriteLine("List: " + string.Join(", ", numbers));

            Console.WriteLine(numbers.Contains(0)); // False, true.
        }
    }
}