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
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
            gotoinsertProductBtnId.Visible = false;
            gotoupdateProductBtnId.Visible = false;
            deleteProductBtnId.Visible = false;
            viewProductTableId.Columns[0].Visible = false;
          
            User user = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (user.RolesId == 1)
                {
                    gotoinsertProductBtnId.Visible = true;
                    gotoupdateProductBtnId.Visible = true;
                    deleteProductBtnId.Visible = true;
                }
                else if (user.RolesId == 2)
                {
                    viewProductTableId.Columns[0].Visible = true;
                }
            }
        }

        protected void addToCartRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("AddToCartPage.aspx?id=" + id);
        }

        protected void viewProductTableId_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[5].Text = "ProductTypes";
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int pTId = Int32.Parse(e.Row.Cells[5].Text);
                Product p = ProductRepository.db.Products.Where(prod => prod.ProductTypeId == pTId).FirstOrDefault();
                e.Row.Cells[5].Text = p.ProductType.Name;
            }
        }

        public void refreshTable()
        {
            viewProductTableId.DataSource = ProductRepository.db.Products.ToList();
            viewProductTableId.DataBind();
        }

        protected void goToInsertProductPg(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductPage.aspx");
        }

        protected void goToUpdateProductPage(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProduct.aspx");
        }

        protected void goToDeletePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProduct.aspx");
        }

    }
}