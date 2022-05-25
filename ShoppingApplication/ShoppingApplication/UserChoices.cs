using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    public enum UserChoices
    {
        DisplayAllProducts=1,
        DisplayProductDetails,
        AddProductToCartBasedOnName,
        AddProductToCartBasedOnId,
        RemoveProductFromCartBasedOnName,
        RemoveProductFromCartBasedOnId,
        DisplayProductsInCart,
        SortProductsInCartBasedOnPrice,
        DisplayTotalPrice,
        End
    }
}
