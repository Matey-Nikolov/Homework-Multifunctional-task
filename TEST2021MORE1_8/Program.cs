namespace TEST2021MORE1_8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<char, int> ch = new Dictionary<char, int>();

            string st = Console.ReadLine().ToLower().ToString();

            for (int i = 0; i < st.Length; i++)
            {

            
                if (!ch.ContainsKey(st[i]))
                {
                    ch.Add(st[i], 1);
                }
                else
                {
                    ch[st[i]] += 1;
                }

            }

            ch = ch.Where(x => x.Value == 1).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in ch)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
