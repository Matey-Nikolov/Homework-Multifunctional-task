namespace StringChar_2._0
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string name = "Iva";

            StringBuilder sb = new StringBuilder();

            sb.Append(name);
            for (int i = 0; i < 500000; i++)
            {
                sb.Append('n');
            }
            name = sb.ToString();
            Console.WriteLine(name);
        }
    }
}
