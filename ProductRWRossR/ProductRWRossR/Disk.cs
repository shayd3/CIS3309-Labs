using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Disk:Media
    {

        public int NumDisks { get; set; }
        public int Size { get; set; }
        public string TypeDisk { get; set; }


        public Disk() { }

        public Disk(int numDisks, int size, string typeDisk)
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
            string ToStringString = getDisplayText("/n");

            return ToStringString;
        }
    }
}
