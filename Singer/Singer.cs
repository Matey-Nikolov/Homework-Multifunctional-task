using System;
using System.Collections.Generic;
using System.Text;

namespace Singer
{
    class Singer
    {

        public string NameFirst { get; set; }

        public string NameLast { get; set; }

        public int Age { get; set; }

        public int Fans { get; set; }

        public string Song { get; set; }

        public string Concert { get; set; }

        public string ShowInfo()
        {
            return $"{NameFirst} {NameLast}: age {Age}.";
        }

        public string CreateSong()
        {
            return $"{Song}";
        }

        public string PlayConcert()
        {
            return $"{NameFirst} play a concert on date 02.06.2021.";
        }
    }
}
