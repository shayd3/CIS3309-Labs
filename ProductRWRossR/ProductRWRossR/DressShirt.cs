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

        public DressShirt(string type, string id, string desc, double price, int qty, string color, string manufacturer, string material, int neck, int sleeve) : base (type, id, desc, price, qty, color, manufacturer, material)
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
            string ToStringString = getDisplayText(" ");

            return ToStringString;
        }


    }
}
