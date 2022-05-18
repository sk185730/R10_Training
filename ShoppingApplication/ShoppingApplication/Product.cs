using System;

namespace ShoppingApplication
{
    public class Product
    {
        private string _productName;
        private int _productId;
        private decimal _productPrice;

        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
