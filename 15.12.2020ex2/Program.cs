namespace _15._12._2020ex2
{
    using System;

    class Program
    {
        static void Main()
        {
            string str1 = "Softuni Svetlina";

            int index1 = str1.IndexOf("regthethr"); 
            int index2 = str1.IndexOf("Softuni");   
            Console.WriteLine(index1);


        }

        static bool StartWhith2(string text, string starWord)
        {
            return text.IndexOf(starWord) == 0;
        }
    }
}
