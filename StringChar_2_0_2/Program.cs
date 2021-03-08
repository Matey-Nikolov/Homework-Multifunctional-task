namespace StringChar_2_0_2
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string text = "Hello. I'm [from] Pravets! I'm C# [developer]!";
            // Hello. I'm From Pravets! I'm C# DEVELOPER!

            Console.WriteLine(Capitals(text));
        }
        /*
        static string NoBuilderCapitals(string text)
        {
            string cap = "";
            bool isCapital = false;

            foreach (char symbol in text)
            {
                if (symbol == '[')
                {
                    isCapital = true;
                }
                else if (symbol == ']')
                {
                    isCapital = false;
                }
                else
                {
                    if (isCapital)
                    {
                        cap += char.ToUpper(symbol);
                    }
                    else
                    {
                        cap += symbol;
                    }
                }
            }
            return cap;
        }
        */
        static string Capitals(string text)
        {
            StringBuilder sb = new StringBuilder();

            bool isCapital = false;

            foreach (char symbol in text)
            {
                if (symbol == '[')
                    isCapital = true;
                else if (symbol == ']')
                    isCapital = false;
                else
                {
                    if (isCapital)
                        sb.Append(char.ToUpper(symbol));
                    else
                        sb.Append(symbol);
                }
            }
            return sb.ToString();
        }
    }
}