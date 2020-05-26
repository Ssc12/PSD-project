using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        public void refreshTable()
        {
            viewPaymentTypeTableId.DataSource = PaymentTypeRepository.db.PaymentTypes.ToList();
            viewPaymentTypeTableId.DataBind();
        }

        protected void gotoInsertPaymentTypePg(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentTypePage.aspx");
        }

        protected void gotoViewUpdatePaymentTypePg(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeletePaymentType.aspx");
        }

        protected void gotoViewDeletePaymentType(object sender, EventArgs e)
        {
            Response.Redirect("ViewUpdateAndDeletePaymentType.aspx");
        }
    }
}