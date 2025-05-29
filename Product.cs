using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Product
    {
        public string name;
        public int price;
        static Product product;
        
        private Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public static Product GetInstance(string name, int price)
        {
            if(product == null)
            {
                product = new Product(name, price);
            }
            return product;
        }
    }
}
