namespace StringChar5
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            /*
            //Конкатенация.
            string str1 = "Hello";
            string str2 = "Softuni";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
            */

            /*
            //Конкатенация.
            string str = "";
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 100000; i++)
            {
                str += i;
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Bye bye");
            */

            StringBuilder sb = new StringBuilder();
            // sb.Capacity = 10000000;
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 500000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(DateTime.Now);

            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}