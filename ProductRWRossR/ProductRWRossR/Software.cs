using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Software:Disk
    {
        public string TypeSoft { get; set; }

        public Software() { }

        public Software(string typeSoft)
        {
            this.TypeSoft = typeSoft; 
        }


        public override string getDisplayText(string sep)
        {
            string text = base.getDisplayText(sep) + sep + TypeSoft;
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
