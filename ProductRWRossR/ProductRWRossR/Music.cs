using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Music:Entertainment

    {
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }


        public Music() { }

        public Music(string artist, string genre, string label)
        {
            this.Artist = artist;
            this.Genre = genre;
            this.Label = label ;

        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Artist + sep + Label + sep + Genre;
            return text;
        }

        public override string ToCSV()
        {
            string CSVString = getDisplayText(",");

            return CSVString;
        }

        public override string ToString()
        {
            string ToStringString = getDisplayText("/n");

            return ToStringString;
        }
    }
}
