using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class DressShirt:Apparel
    {
        public int Neck { get; set; }
        public int Sleeve { get; set; }

        public DressShirt() { }

        public DressShirt(int neck, int sleeve)
        {
            this.Neck = neck;
            this.Sleeve = sleeve;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Neck + sep + Sleeve;
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
