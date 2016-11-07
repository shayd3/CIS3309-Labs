using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Entertainment:Disk
    {
        private TimeSpan runTime;

        public Entertainment() { }

        public Entertainment(TimeSpan runTime)
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
            string ToStringString = getDisplayText("/n");

            return ToStringString;
        }
    }
}
