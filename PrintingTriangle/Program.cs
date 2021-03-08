namespace PrintingTriangle
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

           // PrintLine(number, end);
            PrintingTriangle (number); 
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintingTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
            
            for (int a = number - 1; a >= 1; a--)
            {
                PrintLine(1, a);
            }
        }



    }
}
