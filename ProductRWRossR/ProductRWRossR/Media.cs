using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Media : Product
    {
        private DateTime releaseDate;

        public Media() { }

        public Media(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public string ReleaseDate
        {
            get
            {
                return releaseDate.ToShortDateString();
            }
            set
            {
                DateTime.TryParse(value, out releaseDate);
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
            string ToStringString = getDisplayText("/n");

            return ToStringString;
        }

    }
}
