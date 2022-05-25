using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    interface ICart
    {
        void AddProductToCart(string product);
        void AddProductToCart(int id);
        void RemoveProductFromCart(string product);
        void RemoveProductFromCart(int id);
        void DisplayProductsInCart();
        void SortProductsInCartBasedOnPrice();
        void DisplayTotalPrice();
    }
}
