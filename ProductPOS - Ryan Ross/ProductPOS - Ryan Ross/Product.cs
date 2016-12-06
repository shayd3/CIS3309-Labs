using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    public class Product
    {
        public string Desc { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }

        public int Qty { get; set; }
        public string Type { get; set; }

        public Product() { }

        public Product(string type, string id, string desc , double price, int qty)
        {
            this.Desc = desc;
            this.ID = id;
            this.Price = price;
            this.Qty = qty;
            this.Type = type;
        }

        public virtual string getDisplayText(string sep)
        {
            string text = Type + sep + ID + sep + Desc + sep + Price + sep + Qty;

            return text;
        }

        public virtual string ToCSV()
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