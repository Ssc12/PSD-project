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
    public partial class Home : System.Web.UI.Page
    {
        int tableSize = ProductRepository.db.Products.Count();

        protected void Page_Load(object sender, EventArgs e)
        {           
            randomProductTable();
            randomProductTableId.Columns[0].Visible = false;
            loadPageButtonVisible();

            User user = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (user.RolesId == 1)
                {
                    adminButtonVisible(user);
                }
                else if (user.RolesId == 2)
                {
                    userGreetingId.Text = user.Name;
                    goToViewCartBtn.Visible = true;
                    goToViewTranscactionHistoryBtn.Visible = true;
                    randomProductTableId.Columns[0].Visible = true;
                }
            }
            else
            {
                userGreetingId.Text = "Guest";
            }

        }

        protected void adminButtonVisible(User user)
        {
            recommendedProdectLabel.Visible = false;
            randomProductTableId.Visible = false;
            userGreetingId.Text = user.Name;
            gotoviewUserPgBtnId.Visible = true;
            gotoInsertProductPgBtnId.Visible = true;
            gotoUpdateProductPgBtnId.Visible = true;
            gotoViewProductTypeBtnId.Visible = true;
            gotoInsertProductTypePgBtnId.Visible = true;
            gotoUpdateProductTypePgBtnId.Visible = true;
            gotoviewPaymentTypePgBtn.Visible = true;
            gotoInsertPaymentTypePgBtn.Visible = true;
            gotoUpdatePaymentTypePgBtn.Visible = true;
            goToViewTranscactionHistoryBtn.Visible = true;
            gotoTransactionReportPgBtn.Visible = true;
        }

        protected void loadPageButtonVisible()
        {
            recommendedProdectLabel.Visible = true;
            randomProductTableId.Visible = true;
            gotoviewUserPgBtnId.Visible = false;
            gotoInsertProductPgBtnId.Visible = false;
            gotoUpdateProductPgBtnId.Visible = false;
            gotoViewProductTypeBtnId.Visible = false;
            gotoInsertProductTypePgBtnId.Visible = false;
            gotoUpdateProductTypePgBtnId.Visible = false;
            gotoviewPaymentTypePgBtn.Visible = false;
            gotoInsertPaymentTypePgBtn.Visible = false;
            gotoUpdatePaymentTypePgBtn.Visible = false;
            goToViewCartBtn.Visible = false;
            goToViewTranscactionHistoryBtn.Visible = false;
            gotoTransactionReportPgBtn.Visible = false;
        }

        private Random rand = new Random();
        private List<int> randomList = new List<int>();
        int randomNumber = 0;

        protected void getRandom(int tableSize)
        {
            randomNumber = rand.Next(0, tableSize);
                if (!randomList.Contains(randomNumber))
                    randomList.Add(randomNumber);            
        }

        protected void randomProductTable()
        {
            randomProductTableId.DataSource = ProductRepository.db.Products.ToList();
            randomProductTableId.DataBind();

            while (randomList.Count != 5)
            {
                getRandom(tableSize);
            }
          

            int[] randomNum = randomList.ToArray();

            foreach(int random in randomNum)
            {
                randomProductTableId.Rows[random].Visible = true;
            }

            randomList.Clear();
        }


        protected void randomProductTableId_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[5].Text = "ProductTypes";
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Visible = false;
                int pTId = Int32.Parse(e.Row.Cells[5].Text);
                Product p = ProductRepository.db.Products.Where(prod => prod.ProductTypeId == pTId).FirstOrDefault();
                e.Row.Cells[5].Text = p.ProductType.Name;
            }
        }

        protected void addToCartRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("AddToCartPage.aspx?id=" + id);  
        }

        protected void gotoViewUserPg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void gotoInsertProductPg(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductPage.aspx");
        }

        protected void gotoUpdateProductPg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProduct.aspx");
        }

        protected void gotoViewProduct(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void gotoInsertProductTypePg(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductTypePage.aspx");
        }

        protected void gotoUpdateProductTypePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProductType.aspx");
        }

        protected void gotoViewPaymentTypePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentType.aspx");
        }

        protected void gotoInsertPaymentTypePg(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentTypePage.aspx");
        }

        protected void gotoUpdatePaymentTypePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeletePaymentType.aspx");
        }

        protected void gotoViewCartPage(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }

        protected void gotoViewTransactionHistoryPage(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionHistory.aspx");
        }

        protected void gotoTransactionReportPage(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }
    }
}