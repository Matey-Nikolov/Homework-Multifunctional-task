namespace state_machine3
{
    using System;

    class Program
    {
        enum State { NC, Slash, MLC, Star };

        static void Main()
        {
            State st = State.NC;
            string text = Console.ReadLine();
            Console.WriteLine(PrintWords(text));
            Console.WriteLine("aaaa/*ddsd8*/sdsdd");
        }

        public static string PrintWords(string text)
        {
            State state = State.NC;
            string words = "";
            int count = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (count == 1)
                {
                    break;
                       
                }

                char ch = text[i];

                switch (state)
                {
                    case State.NC:
                        if (ch == '/')
                        {
                            state = State.Slash;
                            start = i;
                        }
                        else
                        {

                        }
                        break;
                    case State.Slash:
                        if (ch == '*')
                        {
                            state = State.MLC;
                        }
                        else if (ch == '/')
                        {

                        }
                        else
                        {
                            state = State.NC;
                        }
                        break;
                    case State.MLC:
                        if (ch == '*')
                        {
                            state = State.Star;
                        }
                        else
                        {
                            // same
                        }
                        break;
                    case State.Star:
                        if (ch == '/')
                        {
                            state = State.NC;
                            end = i;
                            count = 1;
                        }
                        else
                        {
                            state = State.MLC;
                        }
                        break;
                }
            }

            words = text.Substring(start + 2, end - start - 3);

            return words;
        }
    }
}
