using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class CartFactory
    {
        public static Cart createCart(int userId, int productId, int quantity)
        {
            Cart c = new Cart();
            c.UsersId = userId;
            c.ProductsId = productId;
            c.Quantity = quantity;

            return c;
        }
    }
}