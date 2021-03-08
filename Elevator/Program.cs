namespace Elevator
{
    using System;

    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int course = people / capacity + (people % capacity != 0 ? 1 : 0);
            Console.WriteLine(course);
        }
    }
}
