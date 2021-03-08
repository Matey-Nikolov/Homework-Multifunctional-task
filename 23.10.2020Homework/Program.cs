namespace DataTypes
{
    using System;
    using System.Dynamic;

    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            NewMethod(type);

        }

         static void NewMethod(string type)
         {
            switch (type)
            {
                case "int":
                    double num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1 * 2);
                    break;
                case "real":
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1 * 1.5:f2}");
                    break;
                case "string":
                    string word = Console.ReadLine();
                    Console.WriteLine($"${word}$");
                    break;
            }


         }
    }
}
