using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{

    /// <summary>
    /// Provides implementation to ICart methods
    /// </summary>
    class ShoppingCart : ICart, IStore
    {
        VariousProducts variousProducts = new VariousProducts();
        public List<Product> shoppingCart = new List<Product>();
        Product particularProduct;

        #region Option 1 of UserApp switchcase

        /// <summary>
        /// Displays the list of all the products
        /// </summary>
        public void DisplayAllProducts()
        {
            Console.WriteLine("PRODUCTS:");
            foreach (var item in variousProducts.product)
            {
                Console.WriteLine($"> {item.ProductName}");
            }
        }
        #endregion

        #region Option 2 of UserApp switchcase
        /// <summary>
        /// Displays details of a specific product 
        /// </summary>
        /// <param name="product"></param>
        public void DisplayProductDetails(string product)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == product.ToString().ToUpper());
            Console.WriteLine($"\nPRODUCT DETAILS:\nName: {particularProduct.ProductName}\nId: {particularProduct.ProductId}\nPrice: Rs.{particularProduct.ProductPrice}\n");
        }
        #endregion

        #region Option 3 of UserApp switchcase
        /// <summary>
        /// Adds a product to cart based on its name
        /// </summary>
        /// <param name="productName"></param>
        public void AddProductToCart(string productName)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == productName.ToString().ToUpper());
            shoppingCart.Add(particularProduct);
            Console.WriteLine($"{particularProduct.ProductName} added to cart!");
        }
        #endregion

        #region Option 4 of UserApp switchcase
        /// <summary>
        /// Adds a product to cart based on its id
        /// </summary>
        /// <param name="productId"></param>
        public void AddProductToCart(int productId)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductId == productId);
            shoppingCart.Add(particularProduct);
            Console.WriteLine($"Product no. {productId} added to cart!");
        }
        #endregion

        #region Option 5 of UserApp switchcase
        /// <summary>
        /// Removes a product from cart based on its name
        /// </summary>
        /// <param name="productName"></param>
        public void RemoveProductFromCart(string productName)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductName.ToUpper() == productName.ToString().ToUpper());
            shoppingCart.Remove(particularProduct);
            Console.WriteLine($"{particularProduct.ProductName} removed from cart!");
        }
        #endregion

        #region Option 6 of UserApp switchcase
        /// <summary>
        /// Removes a product from cart based on its id
        /// </summary>
        /// <param name="productId"></param>
        public void RemoveProductFromCart(int productId)
        {
            particularProduct = variousProducts.product.Find(x => x.ProductId == productId);
            shoppingCart.Remove(particularProduct);
            Console.WriteLine($"Product no. {productId} removed from cart!");
        }
        #endregion

        #region Option 7 of UserApp switchcase
        /// <summary>
        /// Displays all the products in cart
        /// </summary>
        public void DisplayProductsInCart()
        {
            Console.WriteLine("PRODUCTS IN CART: ");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"> {item.ProductName}");
            }
        }
        #endregion

        #region Option 8 of UserApp switchcase
        /// <summary>
        /// Sorts products in cart based on their price
        /// </summary>
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

        #region Option 9 of UserApp switchcase
        /// <summary>
        /// Displays the total price of products in cart
        /// </summary>
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
