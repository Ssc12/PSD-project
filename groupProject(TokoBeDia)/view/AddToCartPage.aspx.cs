using groupProject_TokoBeDia_.controller;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class AddToCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            toBeAddToCartProductName.Text = p.Name;
            toBeAddToCartProductStock.Text = p.Stock.ToString();
            toBeAddToCartProductPrice.Text = p.Price.ToString();
            toBeAddToCartProductType.Text = p.ProductType.Name;
        }

        protected void addItemToCart(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            String Quantity = addToCartQuantity.Text;
            bool isInputEmpty=false;
            bool isInputNum = false;
            int testNum=0;         

            if (Quantity.Length == 0)
            {
                errorMsgId.Text = "Please insert Quantity to be add to cart";
                isInputEmpty = true;
            }
            else if (!Int32.TryParse(Quantity, out testNum))
            {
                errorMsgId.Text = "input must be numeric";
            }
            else
            {
                isInputNum = true;             
            }

            int itemQuantity;
            try
                {
                    itemQuantity = Int32.Parse(addToCartQuantity.Text);
                }
                catch
                {
                    itemQuantity = 0;
                }

            User user = (User)Session["user"];
            int userId = user.UsersId;
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            int productId = p.ProductsId;
            Cart cart = CartRepository.db.Carts.Where(carts => (carts.ProductsId == id && carts.UsersId == userId)).FirstOrDefault();

            if (itemQuantity <= 0 && isInputEmpty == false && isInputNum == true)
            {
                errorMsgId.Text = "Quantity must more than 0";
            } else if (itemQuantity > p.Stock)
            {
                errorMsgId.Text = "Quantity must be less than or equal to the stock available";
            } else if (cart != null){
                int newItemQuantity = itemQuantity + cart.Quantity;
                CartController.updateCart(userId, productId, newItemQuantity);
                Response.Redirect("ViewCart.aspx");
            } else if (isInputNum == true && isInputEmpty == false)
            {
                CartController.insertToCart(userId, productId, itemQuantity);
                Response.Redirect("ViewCart.aspx");
            }
           
        }
    }
}