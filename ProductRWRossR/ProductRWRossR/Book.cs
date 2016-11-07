﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Book : Media
    {
        public string Author { get; set; }
        public int NumPages { get; set; }
        public string Publisher { get; set; }

        public Book() { }

        public Book(string author, int numPages, string publisher)
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
            string ToStringString = getDisplayText("/n");

            return ToStringString;
        }

    }
}
