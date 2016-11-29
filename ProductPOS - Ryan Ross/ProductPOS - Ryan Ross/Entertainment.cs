using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Entertainment:Disk
    {
        private TimeSpan runTime;

        public Entertainment() { }

        public Entertainment(string type, string id, string desc, double price, int qty, DateTime releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime) :base(type, id, desc, price, qty, releaseDate,numDisks,size,typeDisk)
        {
            this.runTime = runTime;
        }

        public string RunTime
        {
            get
            {
                return runTime.ToString();

            }
            set
            {
                TimeSpan.TryParse(value, out runTime);
            }
        }

        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + RunTime;
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
