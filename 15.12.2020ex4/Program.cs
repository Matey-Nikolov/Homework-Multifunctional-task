namespace _15._12._2020ex4
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = "Hello      Softuni      Svetlina      Sofia";

            string text1 = TrimIntervals(text);
            Console.WriteLine(text1);
        }

        static string TrimIntervals(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    result += str[i];
                }
                else
                {
                    while (str[i + 1] == ' ')
                    {
                        i++; // skip
                    }
                    result += ' ';
                }
            }
            return result;
        }
    }
}
