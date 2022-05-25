using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace ShoppingApplication
{
    class UserApp
    {
        VariousProducts variousProducts = new VariousProducts();
        static protected ILog log = LogManager.GetLogger("Task");
        public static void Main()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\sk185730\source\R10TrainingExercises\R10_Training\ShoppingApplication\ShoppingApplication\log4net.config");
            log4net.Config.XmlConfigurator.Configure(fileInfo);

            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            ShoppingCart shoppingCartHelper = new ShoppingCart();
            UserApp userApp = new UserApp();
            string productNameOption;
            int productIdOption;
            bool applicationRunningState = true;
            
            while (applicationRunningState)
            {
                UserApp.DisplayOperationOptions();
               
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    string X = ((int)UserChoices.DisplayAllProducts).ToString();
                    switch (option)
                    {
                        case (int)UserChoices.DisplayAllProducts:
                            shoppingCartHelper.DisplayAllProducts();
                            break;

                        case (int)UserChoices.DisplayProductDetails:
                            Console.Write("Enter product name: ");
                            productNameOption = Console.ReadLine();
                            if (userApp.ProductNameValidation(productNameOption)) 
                                shoppingCartHelper.DisplayProductDetails(productNameOption);
                            break;

                        case (int)UserChoices.AddProductToCartBasedOnName:
                            Console.Write("Enter product name to add to cart: ");
                            productNameOption = Console.ReadLine();
                            if (userApp.ProductNameValidation(productNameOption))
                                shoppingCartHelper.AddProductToCart(productNameOption);
                                break;

                        case (int)UserChoices.AddProductToCartBasedOnId:
                            Console.Write("Enter product id to add to cart: ");
                            productIdOption = Convert.ToInt32(Console.ReadLine());
                            if (userApp.ProductIdValidation(productIdOption))
                                shoppingCartHelper.AddProductToCart(productIdOption);
                            break;

                        case (int)UserChoices.RemoveProductFromCartBasedOnName:
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                            {
                                Console.Write("Enter product name to remove from cart: ");
                                productNameOption = Console.ReadLine();
                                if (userApp.ProductNameValidation(productNameOption))
                                    shoppingCartHelper.RemoveProductFromCart(productNameOption);
                            }
                            else
                                Console.WriteLine("Cart is empty!");
                            break;

                        case (int)UserChoices.RemoveProductFromCartBasedOnId:
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                            {
                                Console.Write("Enter product id to remove from cart: ");
                                productIdOption = Convert.ToInt32(Console.ReadLine());
                                if (userApp.ProductIdValidation(productIdOption))
                                    shoppingCartHelper.RemoveProductFromCart(productIdOption);
                            }
                            else
                                Console.WriteLine("Cart is empty!");
                            break;

                        case (int)UserChoices.DisplayProductsInCart:
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                                shoppingCartHelper.DisplayProductsInCart();
                            else
                                Console.WriteLine("Cart is empty!");
                                break;

                        case (int)UserChoices.SortProductsInCartBasedOnPrice:
                            if (shoppingCartHelper.shoppingCart.Count != 0)
                                shoppingCartHelper.SortProductsInCartBasedOnPrice();
                            else
                                Console.WriteLine("Cart is empty!");
                            break;

                        case (int)UserChoices.DisplayTotalPrice:
                            shoppingCartHelper.DisplayTotalPrice();
                            break;

                        case (int)UserChoices.End:
                            applicationRunningState = false;
                            Console.WriteLine("Bye!");
                            break;

                        default:
                            throw new InvalidOptionException("Please enter a valid option!");
                    }
                }
                catch (InvalidOptionException ex)
                {
                    log.Error(ex);
                    Console.WriteLine(ex);
                }
                
            }
        }

        /// <summary>
        /// Displays all the operations a user can perform
        /// </summary>
        public static void DisplayOperationOptions()
        {
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("Select operation to perform: ");
            Console.WriteLine("1) Display all products ");
            Console.WriteLine("2) Display particular product details ");
            Console.WriteLine("3) Add item to cart (name):");
            Console.WriteLine("4) Add item to cart (id)");
            Console.WriteLine("5) Remove item from cart (name)");
            Console.WriteLine("6) Remove item from cart (id)");
            Console.WriteLine("7) Display products in cart ");
            Console.WriteLine("8) Sort and Display products in cart based on price");
            Console.WriteLine("9) Display total price ");
            Console.WriteLine("10) Stop shopping");
            Console.WriteLine("______________________________________________________\n");
        }

        /// <summary>
        /// Validates user input (product name)
        /// </summary>
        /// <param name="productOption"></param>
        /// <returns></returns>
        public bool ProductNameValidation(string productOption)
        {
            if (variousProducts.product.Exists(x => x.ProductName.ToUpper() == productOption.ToUpper()))
                return true;
            else
            {
                Console.WriteLine("Invalid product name!");
                return false;
            }
        }

        /// <summary>
        /// Validates user input (product id)
        /// </summary>
        /// <param name="productOption"></param>
        /// <returns></returns>
        public bool ProductIdValidation(int productOption)
        {
            if (variousProducts.product.Exists(x => x.ProductId == productOption))
                return true;
            else
            {
                Console.WriteLine("Invalid product id!");
                return false;
            }
        }

        /// <summary>
        /// Handles all other unhandled exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            log.Error(e.ExceptionObject.ToString());
            Console.WriteLine("Global Exception: " + e.ExceptionObject.ToString());
            
        }
    }
}
