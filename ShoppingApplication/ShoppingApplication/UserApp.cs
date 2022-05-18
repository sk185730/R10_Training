using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    class UserApp
    {
        VariousProducts variousProducts = new VariousProducts();

        public static void Main()
        {
            ShoppingCart shoppingCartHelper = new ShoppingCart();
            UserApp userApp = new UserApp();
            string productOption;
            bool applicationRunningState = true;

            while (applicationRunningState)
            {
                UserApp.DisplayOperationOptions();

                try
                {
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            shoppingCartHelper.DisplayAllProducts();
                            break;

                        case "2":
                            Console.Write("Enter product name: ");
                            productOption = Console.ReadLine();
                            if (userApp.ProductNameValidation(productOption)) 
                                shoppingCartHelper.DisplayProductDetails(productOption);
                            break;

                        case "3":
                            Console.Write("Enter product name to add to cart: ");
                            productOption = Console.ReadLine();
                            if (userApp.ProductNameValidation(productOption))
                                shoppingCartHelper.AddProductToCart(productOption);
                                break;

                        case "4":
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                            {
                                Console.Write("Enter product name to remove from cart: ");
                                productOption = Console.ReadLine();
                                if (userApp.ProductNameValidation(productOption))
                                    shoppingCartHelper.RemoveProductFromCart(productOption);
                            }
                            else
                                Console.WriteLine("Cart is empty!");
                            break;

                        case "5":
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                                shoppingCartHelper.DisplayProductsInCart();
                            else
                                Console.WriteLine("Cart is empty!");
                                break;

                        case "6":
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                                shoppingCartHelper.SortProductsInCartBasedOnPrice();
                            else
                                Console.WriteLine("Cart is empty!");
                            break;

                        case "7":
                            shoppingCartHelper.DisplayTotalPrice();
                            break;

                        case "8":
                            applicationRunningState = false;
                            Console.WriteLine("Bye!");
                            break;

                        default:
                            throw new InvalidOptionException("Please enter a valid option!");
                    }
                }
                catch (InvalidOptionException ex)
                {
                    Console.WriteLine(ex);
                }
                
            }
        }

        public static void DisplayOperationOptions()
        {
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("Select operation to perform: ");
            Console.WriteLine("1) Display all products ");
            Console.WriteLine("2) Display particular product details ");
            Console.WriteLine("3) Add item to cart ");
            Console.WriteLine("4) Remove item from cart");
            Console.WriteLine("5) Display products in cart ");
            Console.WriteLine("6) Sort and Display products in cart based on price");
            Console.WriteLine("7) Display total price ");
            Console.WriteLine("8) Stop shopping");
            Console.WriteLine("______________________________________________________\n");
        }

        public bool ProductNameValidation(string productOption)
        {
            if (variousProducts.product.Exists(x => x.ProductName.ToUpper() == productOption.ToUpper()))
                return true;
            else
            {
                Console.WriteLine("Enter a valid product name!");
                return false;
            }
        }
    }

    public class InvalidOptionException : Exception
    {
        public InvalidOptionException(String message) : base(message)
        {

        }
    }
}
