using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Pants:Apparel
    {
        public int Inseam { get; set; }
        public int Waist { get; set; }

        public Pants() { }

        public Pants(string type, string id, string desc, double price, int qty, string color, string manufacturer, string material, int waist, int inseam) : base(type, id, desc, price, qty, color, manufacturer, material)
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
            string ToStringString = getDisplayText(" ");

            return ToStringString;
        }
    }
}
