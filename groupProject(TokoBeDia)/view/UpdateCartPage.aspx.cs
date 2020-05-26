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
    public partial class UpdateCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.UsersId;
            int id = Int32.Parse(Request.QueryString["id"]);
            Cart c = CartRepository.db.Carts.Where(cart => (cart.ProductsId == id && cart.UsersId == userId)).FirstOrDefault();
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();

            toBeUpdateCartProductName.Text = p.Name;
            toBeUpdateCartProductStock.Text = p.Stock.ToString();
            toBeUpdateCartProductPrice.Text = p.Price.ToString();
            toBeUpdateCartProductType.Text =p.ProductType.Name;
            toBeUpdateCartQuantity.Text = c.Quantity.ToString();
        }

        protected void goUpdateCartQuantity(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);

            String newQuantity = updateNewCartQuantityTb.Text;
            bool isInputEmpty = false;
            bool isInputNum = false;
            int testNum = 0;

            if (newQuantity.Length == 0)
            {
                errorMsgId.Text = "Please insert Quantity to be updated";
                isInputEmpty = true;
            }
            else if (!Int32.TryParse(newQuantity, out testNum))
            {
                errorMsgId.Text = "input must be numeric";
            }
            else
            {
                isInputNum = true;
            }

            int newItemQuantity;
                try
                {
                    newItemQuantity = Int32.Parse(updateNewCartQuantityTb.Text);
                }
                catch
                {
                    newItemQuantity = -1;
                }


            User user = (User)Session["user"];
            int userId = user.UsersId;
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            int productId = p.ProductsId;
            Cart cart = CartRepository.db.Carts.Where(carts => (carts.ProductsId == id && carts.UsersId == userId)).FirstOrDefault();

            if (newItemQuantity < 0 && isInputEmpty == false && isInputNum == true)
            {
                errorMsgId.Text = "Quantity can't below than zero";
            }
            else if (newItemQuantity > (p.Stock + cart.Quantity))
            {
                errorMsgId.Text = "Quantity must be less than or equal to the (remaining stock + quantity you have) maximum";
            }
            else if (newItemQuantity == 0)
            {
                CartController.deleteProductFromCart(userId, productId, cart.Quantity);
                Response.Redirect("ViewCart.aspx");
            }
            else if (newItemQuantity == cart.Quantity)
            {
                errorMsgId.Text = "Quantity to be updated can't be the same amount as current quantity";
            }
            else if (isInputNum == true && isInputEmpty == false)
            {
                CartController.updateCart(userId, productId, newItemQuantity);
                Response.Redirect("ViewCart.aspx");
            }
        }


    }
}