namespace StringChar_2_0_1
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string name = "Softuni"; // inutfos

            Console.WriteLine(Reverse(name));
        }

        static public string Reverse(string str)
        {
            //string rev = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                // rev += str[str.Length - 1 - i];
                //rev += str[i];
                sb.Append(str[str.Length - 1 - i]);
            }
            return sb.ToString();
        }
    }
}