using groupProject_TokoBeDia_.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class CartController
    {
        public static void insertToCart(int userId, int productId, int quantity)
        {
            CartHandler.insertToCart(userId,productId,quantity);
        }

        public static void updateCart(int userId, int productId, int quantity)
        {
            CartHandler.updateCart(userId, productId, quantity);
        }

        public static void deleteProductFromCart(int userId, int productId, int quantity)
        {
            CartHandler.deleteProductFromCart(userId, productId, quantity);
        }

        public static void checkOutProductFromCart(int userId)
        {
            CartHandler.checkOutProductFromCart(userId);
        }
    }
}