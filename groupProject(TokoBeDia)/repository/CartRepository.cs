using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class CartRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void insertToCart(Cart newProductForCart)
        {
            db.Carts.Add(newProductForCart);
            db.SaveChanges();
        }

        public static void updateCart(int userId, int productId, int quantity)
        {
            Cart c = db.Carts.Where(cart => (cart.UsersId == userId && cart.ProductsId == productId)).FirstOrDefault();
            c.Quantity = quantity;
            db.SaveChanges();
        }

        public static void deleteProductFromCart(int userId, int productId, int quantity)
        {
            Cart c = db.Carts.Where(cart => (cart.UsersId == userId && cart.ProductsId == productId)).FirstOrDefault();
            db.Carts.Remove(c);
            db.SaveChanges();
        }

        public static void checkOutProductFromCart(int userId)
        {
            int userCartSize = db.Carts.Where(cart => cart.UsersId == userId).Count();

            while (userCartSize != 0)
            {
                Cart c = db.Carts.Where(cart => cart.UsersId == userId).FirstOrDefault();
                if (c != null)
                {
                    db.Carts.Remove(c);
                    db.SaveChanges();
                }else
                {
                    break;
                }            
            }          
        }
    }
}