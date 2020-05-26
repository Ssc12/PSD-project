using groupProject_TokoBeDia_.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class ProductController
    {
        public static void insertProduct(String name, int stock, int price, int productTypeId)
        {
            ProductHandler.insertProduct(name, stock, price, productTypeId);
        }

        public static void updateProduct(int id,String name, int stock, int price, int productTypeId)
        {
            ProductHandler.updateProduct(id, name, stock, price, productTypeId);          
        }

        public static void deleteProduct(int id)
        {
            ProductHandler.deleteProduct(id);
        }
    }
}