using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class Product
    {
        public string Desc { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }

        internal void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public int Qty { get; set; }
        public string Type { get; set; }

        public Product() { }

        public Product(string desc, string id, double price, int qty, string type)
        {
            this.Desc = desc;
            this.ID = id;
            this.Price = price;
            this.Qty = qty;
            this.Type = type;
        }

        public virtual string getDisplayText(string sep)
        {
            string text = Desc + sep + ID + sep + Price + sep + Qty + sep + Type;

            return text;
        }

        public virtual string ToCSV()
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