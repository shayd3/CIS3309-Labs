using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Software:Disk
    {
        public string TypeSoft { get; set; }

        public Software() { }

        public Software(string type, string id, string desc, double price, int qty, string releaseDate, int numDisks, int size, string typeDisk,string typeSoft) : base(type, id, desc, price, qty, releaseDate, numDisks, size, typeDisk)
        {
            this.TypeSoft = typeSoft; 
        }


        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + TypeSoft;
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
