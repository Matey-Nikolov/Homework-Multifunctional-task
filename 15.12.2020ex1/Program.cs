namespace _15._12._2020ex1
{
    using System;

    class Program
    {
        static void Main()
        {
            string str1 = "Softuni Svetlina";
            string str2 = "Softunirthgjk";

            Console.WriteLine(StartWhith(str1, str2));
        }

        static bool  StartWhith(string text, string starWord)
        {
            for (int i = 0; i < starWord.Length; i++)
            {
                if (text[i] != starWord[i])
                    return false;
                
            }
            return true;
        }

    }
}
