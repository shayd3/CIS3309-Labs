using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Media : Product
    {
        private DateTime releaseDate;

        public Media() { }

        public Media(string type, string id, string desc, double price, int qty, string rDate): base(type, id, desc, price, qty)
        {
            this.ReleaseDate = rDate;
        }

        public string ReleaseDate
        {
            get
            {
                return releaseDate.ToShortDateString();
            }
            set
            {
                this.releaseDate = DateTime.Parse(value);
                //DateTime.TryParse(value, out releaseDate);
            }
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + ReleaseDate;
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
