namespace StringChar6
{

    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
             //string text = "Em "
        }

        static string ReverseText(string text)
        {
            string rev = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                rev += text[i];
            }
            return rev;
        }

        static string ReverseText2(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(i);
            }
            return sb;
        }
    }
}
