namespace oneIf
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = (n >= 0) ? "positive" : "negative";
            Console.WriteLine(result);
            
            Console.WriteLine(Max(20, 15));
        }

        static int Max(int a, int b)
        {
         //   int result = (a > b) ? a : b;
         //   return result;

            return (a > b) ? a : b;

        }

    }
}
