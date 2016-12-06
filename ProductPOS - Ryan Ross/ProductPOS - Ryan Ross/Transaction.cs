using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class Transaction
    {
        private List<Product> lineItems;
        private List<int> qtyOfProducts;

        public Transaction()
        {
            this.lineItems = new List<Product>();
            this.qtyOfProducts = new List<int>();
        }

        public Product ProductAt(int i)
        {
            return this.lineItems[i];
        }

        public int QtyOfProductsAt(int i)
        {
            return this.qtyOfProducts[i];
        }

        public void Add(Product p, int quantity)
        {
            this.lineItems.Add(p);
            this.qtyOfProducts.Add(quantity);
        }

        public void RemoveAt(int i)
        {
            this.lineItems.RemoveAt(i);
            this.qtyOfProducts.RemoveAt(i);
        }

        public void Clear()
        {
            this.lineItems.Clear();
            this.qtyOfProducts.Clear();
        }

    }
}
