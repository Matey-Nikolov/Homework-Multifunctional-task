namespace Char_String_Mega
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                //Task tasks = new Task();
                // Console.WriteLine(tasks.Tasks());


                Console.WriteLine(" 2 - Reverse."); // Ok
                Console.WriteLine("3 - correctly placed brackets."); // Ok
                Console.WriteLine("4 - NroverkaNakloneni"); // Ok
                Console.WriteLine("5 - CountSubstring."); // Ok
                Console.WriteLine("6 - UpCaseTag"); // Ok
                Console.WriteLine("7"); // Ok
                Console.WriteLine("8 - Unicode."); // OK
                Console.WriteLine("9 "); // No
                Console.WriteLine("10 - ExtractText."); // OK
                Console.WriteLine("11 - TextFilter.");  // Ok
                Console.WriteLine("12 - ChangingNumber."); // Ok - no class

                Console.WriteLine("13"); //  90/100
                Console.WriteLine("14 - ReverseText.");  // Ok
                Console.WriteLine("15"); // Ok
                Console.WriteLine(" 16 "); // 30/100
                Console.WriteLine("17 - DateTime"); // OK
                Console.WriteLine("18"); // Ok
                Console.WriteLine("19");
                Console.WriteLine("20");

                Console.WriteLine("21 - Palindromes."); // Ok
                Console.WriteLine("22"); // Ok
                Console.WriteLine("23"); // Ok
                Console.WriteLine("24"); // 90/100
                Console.WriteLine("25 - ReturnWordSort."); // Ok
                Console.WriteLine("26");

                Console.WriteLine("----------------");
                Console.Write("Enter ONLY digits of 1 to 26. ");

                int option = 0;

                int.TryParse(Console.ReadLine(), out option);

                if (1 >= option && option >= 16)
                    continue;
                else
                    option.ToString();


                switch (option)
                {
                    case 2:
                        ReverseString reverse1 = new ReverseString();
                        Console.WriteLine($"Reversed: {reverse1.Revererse()}.");
                        Console.WriteLine("----------------");
                        break;
                    case 3:
                        CaountBrackets();
                        break;

                    case 4:
                        NroverkaNakloneni();
                        break;
                    case 5:
                        _5_CountSubstring countSubstring = new _5_CountSubstring();
                        Console.WriteLine(countSubstring.CountSubstring());
                        Console.WriteLine("----------------");
                        break;
                    case 6:
                        UpCaseTag caseTag = new UpCaseTag();
                        Console.WriteLine(caseTag.UpText());
                        Console.WriteLine("----------------");
                        break;
                    case 7:
                        LongString();
                        break;
                    case 8:
                        // ! ! ! ! ! ! !  ! ! ! ! ! ! !  ! ! ! ! ! ! 
                        //_8_Unicode unicode = new _8_Unicode();
                        Console.WriteLine("----------------");
                        Unicode();
                        break;
                    case 10:
                        _10_ExtractText extractText = new _10_ExtractText();
                        Console.WriteLine("All sentences with this word, which is separated by a space.");
                        Console.WriteLine(string.Join(", ", extractText.Extracts()));
                        Console.WriteLine("----------------");
                        break;
                    case 11:
                        TextFilter filter = new TextFilter();
                        Console.WriteLine(filter.TextFilter1());
                        break;
                    case 12:
                        // ! ! ! ! ! ! !  ! ! ! ! ! ! ! ! ! ! ! ! !  ! ! ! ! ! ! 
                        _12ChangingNumber number = new _12ChangingNumber();
                        Console.WriteLine(number);
                        Console.WriteLine("----------------");
                        break;
                    case 13:
                        ProtocolServerResource();
                        break;
                    case 14:
                        ReverseText reverse = new ReverseText();
                        Console.WriteLine($"Reverse text is: {reverse.Reverse()}");
                        Console.WriteLine("----------------");
                        break;
                    case 15:
                        Dictionary();
                        break;
                    case 16:
                        HTMLDocument();
                        break;
                    case 17:
                        _17DateTime dateTime = new _17DateTime();
                        Console.WriteLine(dateTime.numberOfDaysBetweenThem());
                        Console.WriteLine("----------------");
                        break;
                    case 18:
                        PrintDateAfterHours();

                        break;
                    case 21:
                        PalindromeWord palindromeWords = new PalindromeWord();
                        Console.WriteLine($"Return all words - palindrome: {string.Join(" ", palindromeWords.Palindromes())}");
                        Console.WriteLine("----------------");
                        break;
                    case 22:
                        kdgj2();
                        break;
                    case 23:
                        kdgj();
                        break;
                    case 24:
                        ReplaceChar();
                        break;
                    case 25:
                        _25SortWord sort = new _25SortWord();
                        Console.WriteLine($"Reversed words: {string.Join(" ", sort.ReturnWordSort())}");
                        Console.WriteLine("----------------");
                        break;
                }
            }
        }

        public static void PrintDateAfterHours()
        {
            // 18
            //
            //


        }

        public static void HTMLDocument()
        {
            // 16
            //

            string text = Console.ReadLine();

            string cap = " ";

            int openTag = text.IndexOf("<a href=");
            int closeTag = text.IndexOf("</a>");

            while (openTag != -1 && closeTag != -1)
            {
                cap = text.Substring(openTag + "<a href=".Length, closeTag - openTag - +"</a>".Length);
                text = text.Remove(openTag, closeTag + "</upcase>".Length - openTag);

                text = text.Insert(openTag, "[URL =");



                openTag = text.IndexOf("<a href=", closeTag - "<a href=".Length);
                closeTag = text.IndexOf("</a>", closeTag - "</a>".Length - "<a href=".Length);
            }
            Console.WriteLine(text); ;
        }

        public static void Unicode()
        {
            // 8
            //
            Console.WriteLine("Enter a word in Bulgarian.");
            string word = Console.ReadLine();


            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(@"\u{0:X4}", Convert.ToInt16(word[i]));
            }
        }


    public static void ReplaceChar()
        {
            // 24
            //
            //

            string characterString = Console.ReadLine();

            StringBuilder builderReplace = new StringBuilder();
              

            for (int i = 0; i < characterString.Length; i++)
            {
                char chr = characterString[i];

                int index = characterString.IndexOf(chr, i + 1);

                if (index == -1)
                {
                    builderReplace.Append(chr);
                }
            }

            Console.WriteLine(builderReplace.ToString());
        }

        public static void kdgj2()
        {
            // 22
            //

            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //char[] words = char.ConvertToUtf32(Console.ReadLine());
                

            Dictionary<char, int> kvp = new Dictionary<char, int>();

            foreach (var item in words)
            {
                foreach (char ch in item)
                {
                    if (!kvp.ContainsKey(ch))
                    {
                        kvp.Add(ch, 1);
                    }
                    else
                    {
                        kvp[ch]++;
                    }
                }
            }

            foreach (var item in kvp
                .OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        public static void kdgj()
        {
            //23
            //

            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> kvp = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (!kvp.ContainsKey(words[i]))
                {
                    kvp.Add(words[i], 1);
                }
                else
                {
                    kvp[words[i]]++;
                }
            }

            words.Sort();

            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        public static void Dictionary()
        {
            // 15
            //

            Dictionary<string, string> dictionaryPrograming = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] name = Console.ReadLine()
                    .Split(" - ");

                string word = name[0];
                string explanation = name[1];

                if (!dictionaryPrograming.ContainsKey(word))
                {
                    dictionaryPrograming.Add(word, explanation);
                }
            }

            string word1 = Console.ReadLine();


            foreach (var item in dictionaryPrograming)
            {
                if (item.Key.Contains(word1))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }

        public static void ProtocolServerResource()
        {
            // 13
            //

            string URL = Console.ReadLine();
            string[] URLSplit = URL.Split("://", '/');

            string protocol = "";
            string server = "";
            string resource = "";

            protocol = URLSplit[0];
            string[] serverResource  = URLSplit[1].Split('/');
            server = serverResource[0];
            resource = serverResource[2];

            Console.WriteLine($"protocol = {protocol}");
            Console.WriteLine($"server = {server}");
            Console.WriteLine($"resource = {resource}");
        }





        public static void CaountBrackets()
        {
            // 3
            //

            string task = Console.ReadLine().ToLower();

            int counter = 0;
            int taskLength = task.Length;

            for (int i = 0; i < taskLength; i++)
            {

                if (task[i] == '(')
                {
                    counter++;
                }
                else if (task[i] == ')')
                {
                    counter--;
                }
            }



            if (counter == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }

        public static void LongString()
        {
            // 7
            //

            string str = Console.ReadLine();

            int length = str.Length;

            if (length > 20)
            {
                Console.WriteLine("Try again.");
                str = Console.ReadLine();
                length = str.Length;

                if (length < 20)
                    Console.WriteLine(str.PadRight(20, '*'));
                else if (length == 20)
                    Console.WriteLine(str);
            }
            else if (length < 20)
                Console.WriteLine(str.PadRight(20 ,'*'));
            else if (length == 20)
                Console.WriteLine(str);
        }

        public static void NroverkaNakloneni()
        {
            // 4
            //
            Console.WriteLine("Enter a words by \\");

            string[] words = Console.ReadLine().Split("\\");

            Console.WriteLine("two ");
        }
    }
}