using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class ProductRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void insertProduct(Product newProduct)
        {  
            db.Products.Add(newProduct);
            db.SaveChanges();
        }

        public static void updateProduct(int id, String name, int stock, int price, int productTypeId)
        {
            Product p = db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            p.Name = name;
            p.Stock = stock;
            p.Price = price;
            p.ProductTypeId = productTypeId;
            db.SaveChanges();
        }

        public static void deleteProduct(int id)
        {
            Product p = db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();

            db.Products.Remove(p);
            db.SaveChanges();
        }
    }
}