using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Apparel : Product
    {
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }

        public Apparel() { }

        public Apparel(string color, string manufacturer, string material)
        {
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.Material = material;
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + Material + sep + Color + sep + Manufacturer;
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
