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
    public partial class ViewUpdateAndDeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void updateRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateProductPage.aspx?id=" + id);
        }

        protected void deleteRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            DetailTransaction dt = TransactionRepository.db.DetailTransactions.Where(detTr => detTr.ProductsId == id).FirstOrDefault();
            Cart c = CartRepository.db.Carts.Where(cart => cart.ProductsId == id).FirstOrDefault();
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();

            int idIsUseOnDetailTransaction;
                try
                {
                    idIsUseOnDetailTransaction = dt.ProductsId;
                }
                catch
                {
                    idIsUseOnDetailTransaction = 0;
                }

            int idIsUseOnCart;
                try
                {
                    idIsUseOnCart = c.ProductsId;
                }
                catch
                {
                    idIsUseOnCart = 0;
                }

            if ((idIsUseOnDetailTransaction == p.ProductsId) || (idIsUseOnCart == p.ProductsId))
            {
                validateDeleteIsReferencesID.Text = "Product cannot be delete because it reference on other table";
            }
            else
            {
                ProductController.deleteProduct(id);
                refreshTable();
            }

        }
        protected void refreshTable()
        {
            productListToUpdateAndDeleteId.DataSource = ProductRepository.db.Products.ToList();
            productListToUpdateAndDeleteId.DataBind();
        }

        protected void productListToUpdateAndDeleteId_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[6].Text = "ProductTypes";
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int pTId = Int32.Parse(e.Row.Cells[6].Text);
                Product p = ProductRepository.db.Products.Where(prod => prod.ProductTypeId == pTId).FirstOrDefault();
                e.Row.Cells[6].Text = p.ProductType.Name;
            }
        }
    }
}