namespace StringChar2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            //
            string str = "I study in \"Softuni-Svetlina\"";
            Console.WriteLine(str);
            
            // "\\" - премахва специалното действие.
            string str1 = "I study \\ in \"Softuni-Svetlina\"";
            Console.WriteLine(str1);

            // "\n" - нов ред.
            string str2 = "I study \n in \"Softuni-Svetlina\"";
            Console.WriteLine(str2);

            // "\t" - интервал.
            string str3 = "I study \t in \"Softuni-Svetlina\"";
            Console.WriteLine(str3);

            // "@" - маха всякакво специално действие.
            string str4 = @"I study \n \n in \\\ Softuni-Svetlina\";
            Console.WriteLine(str4);
        }
    }
}