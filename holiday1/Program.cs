namespace holiday1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - CountRealNumbers");
                Console.WriteLine("2 - OddOccurrences");
                Console.WriteLine("3 - WordSynonyms");
                Console.WriteLine();
                Console.WriteLine("Lab: Functional Programming");
                Console.WriteLine("4 - Sort even numbers");
                Console.WriteLine("5 - Sum numbers");
                Console.WriteLine("6 - Count uppercase words");
                Console.WriteLine("7 - Add VAT");
                Console.WriteLine("8 - Filter by age");

                int option = 0;

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        CountRealNumbers();
                        break;
                    case 2:
                        OddOccurrences();
                        break;
                    case 3:
                        WordSynonyms();
                        break;
                    case 4:
                        SortEvenNumbers();
                        break;
                    case 5:
                        SumNumbers();
                        break;
                    case 6:
                        CountUppercaseWords();
                        break;
                    case 7:
                        AddVAT();
                        break;
                    case 8:
                        FilterByAge();
                        break;
                }

                Console.ReadLine();
            }
        }

        static void FilterByAge()
        {
            // 8 

            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                nameAge.Add(name, age);
            }

            string olderOrYounder = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());

            switch (olderOrYounder)
            {
                case "older":
                    Older(nameAge, age2);
                    break;
                case "younger":
                    Younger(nameAge, age2);
                    break;
            }
        }

        static void Younger(Dictionary<string, int> nameAge, int age2)
        {
            // метод за 8
            Dictionary<string, int> result = nameAge
                                             .Where(x => age2 > x.Value)
                                           //  .OrderBy(x => x.Key)
                                             .ToDictionary(x => x.Key, x => x.Value);

            string nameAndAge = Console.ReadLine();

            switch (nameAndAge)
            {
                case "name":
                    foreach (var item in result.OrderByDescending(x => x.Key))
                        Console.WriteLine(item.Key);
                    break;
                case "age":
                    foreach (var item in result)
                        Console.WriteLine(item.Value);
                    break;
                case "name age":
                    foreach (var item in result)
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    break;
            }
        }

        static void Older(Dictionary<string, int> nameAge, int age2)
        {
            // метод за 8

           var result = nameAge
                .Where(x => age2 <= x.Value )
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            string nameAndAge = Console.ReadLine();

            switch (nameAndAge)
            {
                case "name":
                    foreach (var item in result)
                        Console.WriteLine(item.Key);
                    break;
                case "age":
                    foreach (var item in result)
                        Console.WriteLine(item.Value);
                    break;
                case "name age":
                    foreach (var item in result)
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    break;
            }
        }



        static void AddVAT()
        {
            // 7
            List<double> price = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> priceVAT = new List<double>();
            double sum = 0;

            for (int i = 0; i < price.Count; i++)
            {
                sum = price[i] + (price[i] * 0.20);
                priceVAT.Add(sum);
                sum = 0;
            }

            foreach (var totalPrice in priceVAT)
                Console.WriteLine($"{totalPrice:f2}");
        }

        private static void CountUppercaseWords()
        {
            // 6
            List<string> text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> saveText = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                for (int a = 0; a < text[i].Length; a++)
                {
                    if (char.Parse(text[a]) == 'T')
                    {
                        saveText.Add(text[i]);
                    }
                }
            }

            foreach (var item in saveText)
            {
                Console.WriteLine(item);
            }
        }

        static void SumNumbers()
        {
            // 5
            List<int> numbres = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < numbres.Count; i++)
            {
                sum += numbres[i];
            }

            Console.WriteLine(numbres.Count);
            Console.WriteLine(sum);
        }

        static void SortEvenNumbers()
        {
            // 4

            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(num => num)
                .ToList();

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void WordSynonyms()
        {
            // 3

            var words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonyms);
            }

            Console.WriteLine($"{words.Keys} - {words.Values}, ");
        }

        static void OddOccurrences()
        {
            // 2

            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> OddName = new Dictionary<string, int>();


            foreach(var word in words)
            {
                string wordLower = word.ToLower();
                if (!OddName.ContainsKey(wordLower))
                {
                    OddName.Add(wordLower, 1);
                }
                else
                    OddName[wordLower]++;
            }

            foreach (var item in OddName)
            {
                if(item.Value % 2 != 0)
                    Console.Write($"{item.Key} ");
            }

        }

        static void CountRealNumbers()
        {
            //  1

            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 1);
                }
                else
                {
                    counts[number]++;
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
