using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Book : Media
    {
        public string Author { get; set; }
        public int NumPages { get; set; }
        public string Publisher { get; set; }

        public Book() { }

        public Book(string type, string id, string desc, double price, int qty, string releaseDate, string author, int numPages  , string publisher) : base (type, id, desc, price, qty, releaseDate)
        {
            this.Author = author;
            this.NumPages = numPages;
            this.Publisher = publisher;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Author + sep + NumPages + sep + Publisher;
            return text;
        }

        public override string ToCSV()
        {
            string CSVString = getDisplayText(",");

            return CSVString;
        }

        public override string ToString()
        {
            string ToStringString = getDisplayText(" ");

            return ToStringString;
        }

    }
}
