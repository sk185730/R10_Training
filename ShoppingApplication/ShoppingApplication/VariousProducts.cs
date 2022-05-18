using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    class VariousProducts
    {
        public List<Product> product;
        public VariousProducts()
        {
            Product product1 = new Product() { ProductId = 101, ProductName = "Pen", ProductPrice = 20 };
            Product product2 = new Product() { ProductId = 102, ProductName = "Soap", ProductPrice = 100};
            Product product3 = new Product() { ProductId = 103, ProductName = "Shampoo", ProductPrice = 300};
            Product product4 = new Product() { ProductId = 104, ProductName = "Watch", ProductPrice = 4000 };
            Product product5 = new Product() { ProductId = 105, ProductName = "Paints", ProductPrice = 900};
            product = new List<Product>() {product1, product2, product3, product4, product5 };
        }
    }
}
