using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    class ShoppingCart
    {
        VariousProducts variousProducts = new VariousProducts();
        public List<Product> shoppingCart = new List<Product>();
        Product particularProduct;

        #region 1
        public void DisplayAllProducts()
        {
            Console.WriteLine("PRODUCTS:");
            foreach (var item in variousProducts.product)
            {
                Console.WriteLine($"> {item.ProductName}");
            }
        }
        #endregion

        #region 2
        public void DisplayProductDetails(string product)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == product.ToString().ToUpper());
            Console.WriteLine($"\nPRODUCT DETAILS:\nName: {particularProduct.ProductName}\nId: {particularProduct.ProductId}\nPrice: Rs.{particularProduct.ProductPrice}\n");
        }
        #endregion

        #region 3
        public void AddProductToCart(string product)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == product.ToString().ToUpper());
            shoppingCart.Add(particularProduct);
            Console.WriteLine($"{particularProduct.ProductName} added to cart!");
        }
        #endregion

        #region 4
        public void RemoveProductFromCart(string product)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == product.ToString().ToUpper());
            shoppingCart.Remove(particularProduct);
            Console.WriteLine($"{particularProduct.ProductName} removed from cart!");
        }
        #endregion

        #region 5
        public void DisplayProductsInCart()
        {
            Console.WriteLine("PRODUCTS IN CART: ");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"> {item.ProductName}");
            }
        }
        #endregion

        #region 6
        public void SortProductsInCartBasedOnPrice()
        {
            Console.WriteLine("SORTED PRODUCTS BASED ON PRICE:  ");
            shoppingCart.Sort((lhs, rhs) => (lhs.ProductPrice.CompareTo(rhs.ProductPrice)));
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"> {item.ProductName} : Rs.{item.ProductPrice}");
            }
        }
        #endregion

        #region 7
        public void DisplayTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in shoppingCart)
            {
                totalPrice +=item.ProductPrice;
            }
            Console.WriteLine($"TOTAL PRICE: Rs.{totalPrice}");
        }
        #endregion
    }
}
