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
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }
     
        protected void updateCartRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateCartPage.aspx?id=" + id);
        }

        protected void deleteCartRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);

            User user = (User)Session["user"];
            int userId = user.UsersId;
            Cart c = CartRepository.db.Carts.Where(cart => (cart.ProductsId == id && cart.UsersId == userId)).FirstOrDefault();
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            
            CartController.deleteProductFromCart(userId, id, c.Quantity);
            GrandTotal = 0;
            refreshTable();
        }

        protected void goCheckOutTansaction(object sender, EventArgs e)
        {
            String paymentType = insertPaymentTypeTb.Text;

            PaymentType payType = PaymentTypeRepository.db.PaymentTypes.Where(pt => pt.Type.Equals(paymentType)).FirstOrDefault();
            String availablePayTypeName;
                try
                {
                    availablePayTypeName = payType.Type;
                }
                catch
                {
                    availablePayTypeName = "";
                }

            User user = (User)Session["user"];
            int userId = user.UsersId;
            Cart cart = CartRepository.db.Carts.Where(c => c.UsersId == userId).FirstOrDefault();
            List<Cart> cartList = CartRepository.db.Carts.Where(c => c.UsersId == userId).ToList();
            
            
            if (cart == null)
            {
                errorMsgId.Text = "Cart is Empty, please add some product to cart in order to checkout";
            }
            else if(paymentType.Length == 0)
            {
                errorMsgId.Text = "Please insert Payment type to continue";
            }else if (!availablePayTypeName.Equals(paymentType))
            {
                errorMsgId.Text = "Please insert the available payment Type";
            }else
            {
                int paymentTypeId = payType.PaymentTypesId;
                DateTime date = DateTime.Now;
                TransactionController.checkout(userId, cartList, paymentTypeId, date);
                CartController.checkOutProductFromCart(userId);
                Response.Redirect("Home.aspx");
            }

            cartList.Clear();
        }

        protected void refreshTable()
        {
            User user = (User)Session["user"];
            int userId = user.UsersId;

            cartListToUpdateAndDeleteId.DataSource = CartRepository.db.Carts.Where(cart => cart.UsersId == userId).ToList();
            cartListToUpdateAndDeleteId.DataBind();

            availablePaymentTypeView.DataSource = PaymentTypeRepository.db.PaymentTypes.ToList();
            availablePaymentTypeView.DataBind();
        }


        int GrandTotal = 0;
        protected void cartListToUpdateAndDeleteId_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false;
            e.Row.Cells.Add(e.Row.Cells[2]); // product name
            e.Row.Cells.Add(e.Row.Cells[2]); // product price
            e.Row.Cells.Add(e.Row.Cells[2]); // subtotal

            if (e.Row.RowType == DataControlRowType.Header)
            { 
                e.Row.Cells[4].Text = "ProductName";
                e.Row.Cells[5].Text = "ProductPrice";
                e.Row.Cells[6].Text = "Quantity";
                e.Row.Cells[7].Text = "SubTotal";
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int pId = Int32.Parse(e.Row.Cells[3].Text);
                Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == pId).FirstOrDefault();
                User user = (User)Session["user"];
                int userId = user.UsersId;
                Cart c = CartRepository.db.Carts.Where(cart => (cart.ProductsId == pId && cart.UsersId == userId)).FirstOrDefault();
                e.Row.Cells[4].Text = p.Name;
                e.Row.Cells[5].Text = p.Price.ToString();
                e.Row.Cells[6].Text = c.Quantity.ToString();
                e.Row.Cells[7].Text = (c.Quantity * p.Price).ToString();

                GrandTotal =  GrandTotal + Int32.Parse(e.Row.Cells[7].Text);
            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[6].Text = "GrandTotal";
                e.Row.Cells[7].Text = GrandTotal.ToString();
            }
        }
    }
}