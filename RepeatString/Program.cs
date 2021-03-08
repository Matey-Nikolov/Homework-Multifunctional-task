using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string result = RepeatString(text, repeat);
            Console.WriteLine(result);

            // Console.WriteLine(RepeatString(text, repeat));
        }
            
        static string RepeatString(string text, int q)
        {
            string repeatString = string.Empty; // замества  "";

            for (int i = 0; i < q; i++)
            {
                repeatString += text;
            }

            return repeatString;
        }



    }
}