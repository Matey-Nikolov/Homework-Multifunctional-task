using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - Exit.");
                Console.WriteLine("2 - Reverse."); // Ok
                Console.WriteLine("3 - correctly placed brackets."); // Ok
                Console.WriteLine("4 - NroverkaNakloneni"); // Ok
                Console.WriteLine("5 - CountSubstring."); // Ok
                Console.WriteLine("6 - UpCaseTag."); // Ok
                Console.WriteLine("7 - LongString."); // Ok
                                                      
                Console.WriteLine("8 - Unicode."); // OK
                Console.WriteLine("9 - CodingGivenCipher."); // Ok
                Console.WriteLine("10 - ExtractText."); // OK
                Console.WriteLine("11 - TextFilter.");  // Ok
                Console.WriteLine("12 - ChangingNumber."); // Ok - no class

                Console.WriteLine("13 - ProtocolServerResource."); //  Ok
                Console.WriteLine("14 - ReverseText.");  // Ok
                Console.WriteLine("15 - Dictionary."); // Ok
                Console.WriteLine("16 - HTMLDocument."); // Ok
                Console.WriteLine("17 - DateTime."); // OK
                Console.WriteLine("18 - PrintDateAfterHours."); // Ok
                Console.WriteLine("19 - RetrieveEmails."); // Ok
                Console.WriteLine("20 - PrintDateCanada."); // Ok

                Console.WriteLine("21 - Palindromes."); // Ok
                Console.WriteLine("22 - lettersSort."); // Ok
                Console.WriteLine("23 - WordsSort."); // Ok
                Console.WriteLine("24 - ReplaceChar."); // OK
                Console.WriteLine("25 - ReturnWordSort."); // Ok
                Console.WriteLine("26 - HTMLNoTags."); //  Ok
                Console.WriteLine("----------------");

                Console.Write("Enter ONLY digits of 1 to 26. ");
                int option = 0;


                int.TryParse(Console.ReadLine(), out option);


                if (option < 1 || 26 < option)
                    continue;
                else
                    option.ToString();


                switch (option)
                {
                    case 2:
                        ReverseString_2 reverse1 = new ReverseString_2();
                        Console.WriteLine($"Reversed: {reverse1.Revererse()}.");
                        Console.WriteLine("----------------");
                        break;
                    case 3:
                        CountBracket bracket = new CountBracket();
                        Console.WriteLine(bracket.CountBrackets());
                        Console.WriteLine("----------------");
                        break;
                    case 4:
                        HowInclined_4 howInclined = new HowInclined_4();
                        Console.WriteLine(howInclined.lined());
                        Console.WriteLine("----------------");
                        break;
                    case 5:
                        CountSubstring_5 countSubstring = new CountSubstring_5();
                        Console.WriteLine($"Only words is not ban: {countSubstring.CountSubstring()}.");
                        Console.WriteLine("----------------");
                        break;
                    case 6:
                        UpCaseTag_6 caseTag = new UpCaseTag_6();
                        Console.WriteLine(caseTag.UpText());
                        Console.WriteLine("----------------");
                        break;
                    case 7:
                        LongString_7 word20 = new LongString_7();
                        Console.WriteLine(word20.Text());
                        Console.WriteLine("----------------");
                        break;
                    case 8:
                        // ! ! ! ! ! ! !  ! ! ! ! ! ! !  ! ! ! ! ! ! 
                        //Unicode unicode = new Unicode();
                        ReturnUnicode();
                        Console.WriteLine("----------------");
                        break;
                    case 9:
                        CodingGivenCipher();
                        Console.WriteLine("----------------");
                        break;
                    case 10:
                        ExtractText_10 extractText = new ExtractText_10();
                        Console.WriteLine();
                        Console.WriteLine($"All sentences with this word, which is separated by a space: {string.Join(", ", extractText.Extracts())}");
                        Console.WriteLine("----------------");
                        break;
                    case 11:
                        TextFilter_11 filter = new TextFilter_11();
                        Console.WriteLine($"The text with the masked words: {filter.TextFilter1()}");
                        Console.WriteLine("----------------");
                        break;
                    case 12:
                        // ! ! ! ! ! ! !  ! ! ! ! ! ! ! ! ! ! ! ! !  ! ! ! ! ! ! 
                        //  _12ChangingNumber number = new _12ChangingNumber();
                        ChangingNumber();
                        Console.WriteLine("----------------");
                        break;
                    case 13:
                        ProtocolServerResource();
                        Console.WriteLine("----------------");
                        break;
                    case 14:
                        ReverseText_14 reverse = new ReverseText_14();
                        Console.WriteLine($"Reverse text is: {reverse.Reverse()}");
                        Console.WriteLine("----------------");
                        break;
                    case 15:
                        ClassWord_15 word = new ClassWord_15();
                        Console.WriteLine($"The meaning of the word: {word.DictionaryOfWords()}");
                        Console.WriteLine("----------------");
                        break;
                    case 16:
                        HTMLDocument document = new HTMLDocument();
                        Console.WriteLine($"HTML doc: {document.DocumentRegex()}");
                        Console.WriteLine("----------------");
                        break;
                    case 17:
                        DateTime_17 dateTime = new DateTime_17();
                        Console.WriteLine(dateTime.numberOfDaysBetweenThem());
                        Console.WriteLine("----------------");
                        break;
                    case 18:
                        DateAndHour_18 dateAndHour = new DateAndHour_18();
                        Console.WriteLine($"Change of time after 6 hours and 30 minutes {dateAndHour.PrintDateAfterHours()}.");
                        Console.WriteLine("----------------");
                        break;
                    case 19:
                        RetrieveEmails();
                        Console.WriteLine("----------------");
                        break;
                    case 20:
                        PrintDateCanada();
                        Console.WriteLine("----------------");
                        break;
                    case 21:
                        PalindromeWord palindromeWords = new PalindromeWord();
                        Console.WriteLine($"Return all words - palindrome: {string.Join(" ", palindromeWords.Palindromes())}");
                        Console.WriteLine("----------------");
                        break;
                    case 22:
                        Class_letter letter = new Class_letter();
                        letter.lettersSort();
                        Console.WriteLine("----------------");
                        break;
                    case 23:
                        WordsSort();
                        Console.WriteLine("----------------");
                        break;
                    case 24:
                        ReplaceChar replace = new ReplaceChar();
                        Console.WriteLine($"One char no duplica: {replace.Relace()}.");
                        Console.WriteLine("----------------");
                        break;
                    case 25:
                        SortWord_25 sort = new SortWord_25();
                        Console.WriteLine($"Sorts words: {string.Join(" ", sort.ReturnWordSort())}");
                        Console.WriteLine("----------------");
                        break;
                    case 26:
                        HTMLNoTags();
                        Console.WriteLine("----------------");
                        break;
                    case 1:
                        return;
                }
            }
        }

        public static void HTMLNoTags()
        {
            Console.Write("Enter a HTML with tags: ");
            string content = Console.ReadLine();

            /*
            string content = "<html>" +
                            "<head><title>News</title></head>" +
                            "<body><p><a href=\"https://softuni.bg\">Telerik Academy </a>" +
                            "aims to provide free real-world practical " +
                            "training for young people who want to turn " +
                            "into skillful .NET software engineers.</p></body>" +
                            "</html>";
            */
            string pattern = @"<title>([a-z]*)</title>";
            Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Match match = rx.Match(content);
            Console.WriteLine($"Title: {match.Groups[1].Value}");
            content = Regex.Replace(content, pattern, "");

            pattern = @"<[^>]*>";
            content = Regex.Replace(content, pattern, "");
            Console.WriteLine("Body:");
            Console.WriteLine(content);
        }

        public static void PrintDateCanada()
        {
            //20 
            Console.Write("Enter a text and one date (dd.mm.yyyy): ");
            string content = Console.ReadLine();
            // string content = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
            string pattern = @"\d{1,2}.\d{1,2}.\d{4}";

            Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Match match = rx.Match(content);

            CultureInfo CurrentCulture = new CultureInfo("en-CA");

            Console.WriteLine("Print all date in Canada format.");
            while (match.Success)
            {
                Console.WriteLine($"{match.Value}");
                match = match.NextMatch();
            }
        }

        public static void RetrieveEmails()
        {
            // 19
            Console.Write("Enter text and a valid mail: ");
            string content = Console.ReadLine();
            //string content = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @softuni.bg.com. Neither this: a@a.b.";

            string pattern = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}";
            Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match match = rx.Match(content);
            Console.WriteLine("Valid mail.");
            while (match.Success)
            {
                Console.WriteLine($"{match.Value}");
                match = match.NextMatch();
            }
        }

        public static void CodingGivenCipher()
        {

            Console.Write("Enter a text: ");
            string inputString = Console.ReadLine();
            Console.Write("Enter a cipher: ");
            string key = Console.ReadLine();

            int keyIndex = 0;

            Console.WriteLine("Cipher text.");
            for (int i = 0; i < inputString.Length; i++)
            {
                Console.Write(@"\u{0:x4}", (ushort)(inputString[i] ^ key[keyIndex++]));
                if (keyIndex > key.Length - 1) keyIndex = 0;
            }
            Console.WriteLine();
        }

        public static void ChangingNumber()
        {
            // 12
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number aligned to the right as decimal, percentage, 16, currency.");

            Console.WriteLine("{0,15:D}", number.ToString("D"));
            Console.WriteLine("{0,15}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:E}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:C}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:X}", Convert.ToInt32(number));
            Console.WriteLine("{0,15:P}", Convert.ToInt32(number));

        }

        public static void ReturnUnicode()
        {
            // 8
            //
            Console.Write("Enter a word/name: ");
            string word = Console.ReadLine();

            Console.WriteLine("Unique code of the word/name is: ");
            for (int i = 0; i < word.Length; i++)
                Console.Write(@"\u{0:X4}", Convert.ToInt16(word[i]));
        }

        public static void WordsSort()
        {
            //23
            //

            Console.Write("Enter a words: ");
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> kvp = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (!kvp.ContainsKey(words[i]))
                    kvp.Add(words[i], 1);
                else
                    kvp[words[i]]++;
            }

            words.Sort();
            Console.WriteLine("All words and how many times they occur.");
            foreach (var item in kvp)
                Console.WriteLine($"{item.Key} - {item.Value}");
        }

        public static void ProtocolServerResource()
        {
            // 13
            Console.Write("Enter a web address: ");
            string address = Console.ReadLine();
            //string address = "https://www.devbg.hu.org/forum/test01/test02/index01.php";
            //   string pattern = @"^(https?)://([a-z0-9-_.]*)((/[a-z0-9-_.]*)*)";

            string pattern = @"(https?)://([a-z.-_0-9]+\.[a-z]{2,3})(/[/.a-z0-9]*)";

            Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            var match = rx.Match(address);

            Console.WriteLine($"[protocol] =\"{match.Groups[1].Value}\"");
            Console.WriteLine($"[server]=\"{match.Groups[2].Value}\"");
            Console.WriteLine($"[resources]=\"{match.Groups[3].Value}\"");
        }
    }
}