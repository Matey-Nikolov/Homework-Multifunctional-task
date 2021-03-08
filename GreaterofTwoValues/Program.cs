namespace GreaterofTwoValues
{
    using System;
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            switch (name)
            {
                case "int":
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    int number = GetMaxNumber(x, y);
                    Console.WriteLine(number);
                    break;
                case "char":
                    char az = char.Parse(Console.ReadLine());
                    char az2 = char.Parse(Console.ReadLine());
                    char  a = GetMaxChar(az, az2);
                    Console.WriteLine(a);
                    break;
                case "string":
                    string abc = Console.ReadLine();
                    string abc2 = Console.ReadLine();
                    string abcd = GetMaxString(abc, abc2);
                    Console.WriteLine(abcd);
                    break;
            }
        }
        
        static int GetMaxNumber(int x, int y)
        {
           // int x = int.Parse(Console.ReadLine());
           // int y = int.Parse(Console.ReadLine());
            int min = 0;
         
                 min = Math.Max(x, y);
            return min;
        }
            
        static char GetMaxChar(char az, char az2)
        {
           // char az = char.Parse(Console.ReadLine());
          //  char az2 = char.Parse(Console.ReadLine());

            if (az > az2)
                return az;
            else
                return az2;
        }

        static string GetMaxString(string abc, string abc2)
        {
            //   string abc = Console.ReadLine();
            //   string abc2 = Console.ReadLine();

            if (abc.CompareTo(abc2) > 0) // Взимаме аски, а не дължината.
                return abc;
            else
                return abc2;
        }
    }

}