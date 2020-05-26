using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class CartHandler
    {
        public static void insertToCart(int userId, int productId, int quantity)
        {
            Cart newCart = CartFactory.createCart(userId, productId, quantity);
            CartRepository.insertToCart(newCart);
             
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == productId).FirstOrDefault();
            int updatedProductStock = p.Stock - quantity;
            ProductRepository.updateProduct(p.ProductsId, p.Name, updatedProductStock, p.Price, p.ProductTypeId);
        }

        public static void updateCart(int userId, int productId, int quantity)
        {           
            Cart cart = CartRepository.db.Carts.Where(carts => (carts.ProductsId == productId && carts.UsersId == userId)).FirstOrDefault();
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == productId).FirstOrDefault();

            int updatedProductStock = p.Stock - (quantity - cart.Quantity);
            ProductRepository.updateProduct(p.ProductsId, p.Name, updatedProductStock, p.Price, p.ProductTypeId);
            CartRepository.updateCart(userId, productId, quantity);
        }

        public static void deleteProductFromCart(int userId, int productId, int quantity)
        {
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == productId).FirstOrDefault();
            int updatedProductStock = p.Stock + quantity;
            ProductRepository.updateProduct(p.ProductsId, p.Name, updatedProductStock, p.Price, p.ProductTypeId);
            quantity = 0;
            CartRepository.deleteProductFromCart(userId, productId, quantity);
        }

        public static void checkOutProductFromCart(int userId)
        {
            CartRepository.checkOutProductFromCart(userId);
        }
    }
}