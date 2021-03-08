namespace StringChar3
{
    using System;

    class Program
    {
        static void Main()
        {
            //case-sehs "=="
            string str1 = "hello";
            string str2 = "hello";

            Console.WriteLine(str1.Equals(str2)); // str1 == str2

            //CompareTo(); 
            Console.WriteLine(str1.CompareTo(str2)); // 0 - когато са еднакви. 1 и -1.
        }
    }
}