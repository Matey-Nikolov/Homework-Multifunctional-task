namespace state_machine
{
    using System;
 
    class Program
    {
        enum State { NULL, S, SO, SOS };

        static void Main()
        {
            State st = State.NULL;
            Console.WriteLine(CountSOS("sdfSOSSOSt"));
        }

        static bool FindSOS(string text)
        {
            State state = State.NULL;   

            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'S')
                        {
                            state = State.S;
                        }
                        break;
                    case State.S:
                        if (ch == 'O')
                        {
                            state = State.SO;
                        }
                        else if (ch == 'S')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.SO:
                        if (ch == 'S')
                        {
                            state = State.SOS;
                            return true;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }
            return false;
        }

        static int CountSOS(string text)
        {
            int count = 0;
            State state = State.NULL;

            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'S')
                        {
                            state = State.S;
                        }
                        break;
                    case State.S:
                        if (ch == 'O')
                        {
                            state = State.SO;
                        }
                        else if (ch == 'S')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.SO:
                        if (ch == 'S')
                        {
                            state = State.SOS;
                            count++;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.SOS:
                        if (ch == 'S')
                        {
                            state = State.S;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }
            return count;
        }

    }
}