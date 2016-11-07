using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRossR
{
    class ProductList:List<Product>
    {
        public void Add(Product product)
        {
            this.Insert(0, product); //Is this right?...
        }


    }
}
