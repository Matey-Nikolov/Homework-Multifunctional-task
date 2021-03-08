﻿namespace state_machine2
{
    using System;
    class Program
    {
        enum State { NULL, N, NA, NAN, NANO };

        static void Main()
        {

            Console.WriteLine(FindNano("esfsjnfkNNANOwd"));
            Console.WriteLine(CountNano("esfsjnfkNANOijnNANO".ToUpper()));
        }

        static bool FindNano(string text)
        {
            State state = State.NULL;

            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;
                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
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

        static int CountNano(string text)
        {
            int count = 0;
            State state = State.NULL;

            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;
                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            // same state
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
                            count++;
                        }
                        else if (ch == 'N')
                        {
                            state = State.N;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                    case State.NANO:
                        if (ch == 'N')
                        {
                            state = State.N;
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