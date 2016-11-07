using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Movie:Entertainment
    {
        public string Director { get; set; }
        public string Producer { get; set; }

        public Movie() { }

        public Movie(string director, string producer)
        {
            this.Director = director;
            this.Producer = producer;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Director + sep + Producer;
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
