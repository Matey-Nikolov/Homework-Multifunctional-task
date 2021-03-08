namespace _15._12._2020ex3
{
    using System;
    
    class Program
    {
        static void Main()
        {
            string str1 = "Softuni" + "Svetlina";
            string city = "Sofia";
            string str2 = str1 + "-" + city;

            Console.WriteLine(ReverseStr(str1));
        }

        static string ReverseStr(string str)
        {
            string result = "";

            /*
            for (int i = 0; i < str.Length; i++)
            {
                result += str[str.Length - 1 - i];
            }
            */

            for (int i =str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
