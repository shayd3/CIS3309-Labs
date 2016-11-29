using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Disk:Media
    {

        public int NumDisks { get; set; }
        public int Size { get; set; }
        public string TypeDisk { get; set; }


        public Disk() { }

        public Disk(string type, string id, string desc, double price, int qty, DateTime releaseDate,int numDisks, int size, string typeDisk) : base(type, id, desc, price, qty, releaseDate)
        {
            this.NumDisks = numDisks;
            this.Size = size;
            this.TypeDisk = typeDisk;
        }


        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + NumDisks + sep + Size + sep + TypeDisk;
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
