using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class ProductHandler
    {
        public static void insertProduct(String name, int stock, int price, int productTypeId)
        {
            Product newProduct = ProductFactory.createProduct(name, stock, price, productTypeId);
            ProductRepository.insertProduct(newProduct);
        }

        public static void updateProduct(int id, String name, int stock, int price, int productTypeId)
        {
            ProductRepository.updateProduct(id, name, stock, price, productTypeId);
        }

        public static void deleteProduct(int id)
        {
            ProductRepository.deleteProduct(id);
        }
    }
}