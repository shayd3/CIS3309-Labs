using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Pants:Apparel
    {
        public int Inseam { get; set; }
        public int Waist { get; set; }

        public Pants() { }

        public Pants(int inseam, int waist)
        {
            this.Inseam = inseam;
            this.Waist = waist;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Waist + sep + Inseam;
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
