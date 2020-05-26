using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            viewProductTypeTableId.DataSource = ProductTypeRepository.db.ProductTypes.ToList();
            viewProductTypeTableId.DataBind();
        }

        protected void gotoInsertProductTypePg(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductTypePage.aspx");
        }

        protected void gotoViewUpdateProductTypePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProductType.aspx");
        }

        protected void gotoViewDeleteProductType(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeleteProductType.aspx");
        }

    }
}