namespace Lab_Strings_and_Text_Processing_5
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string isDigits = "";
            string isLetter = "";
            string isCharacters = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                    isDigits += text[i];
                else if (char.IsLetter(text[i]))
                    isLetter += text[i];
                else
                    isCharacters += text[i];
            }

            Console.WriteLine(isDigits);
            Console.WriteLine(isLetter);
            Console.WriteLine(isCharacters);
        }
    }
}
