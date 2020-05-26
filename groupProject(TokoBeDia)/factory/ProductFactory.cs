using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class ProductFactory
    {
        public static Product createProduct(String name, int stock, int price, int productTypeId)
        {
            Product p = new Product();
            p.Name = name;
            p.Stock = stock;
            p.Price = price;
            p.ProductTypeId = productTypeId;

            return p;
        }
    }
}