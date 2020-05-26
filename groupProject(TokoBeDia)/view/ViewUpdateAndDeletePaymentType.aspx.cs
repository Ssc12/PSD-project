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
    public partial class ViewUpdateAndDeletePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void updateRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdatePaymentTypePage.aspx?id=" + id);
        }

        protected void deleteRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);

            PaymentType pt = PaymentTypeRepository.db.PaymentTypes.Where(payType => payType.PaymentTypesId == id).FirstOrDefault();
            HeaderTransaction ht = TransactionRepository.db.HeaderTransactions.Where(headTran => headTran.PaymentTypeId == id).FirstOrDefault();

            int idIsUseOnTransaction;
            try
            {
                idIsUseOnTransaction = ht.PaymentTypeId;
            }
            catch
            {
                idIsUseOnTransaction = 0;
            }


            if (idIsUseOnTransaction == pt.PaymentTypesId)
            {
                validateDeleteIsReferencesID.Text = "Payment Type cannot be delete because it reference on other table";
            }
            else
            {
                PaymentTypeController.deletePaymentType(id);
                refreshTable();
            }


        }

        protected void refreshTable()
        {
            paymentTypeListToUpdateAndDeleteId.DataSource = PaymentTypeRepository.db.PaymentTypes.ToList();
            paymentTypeListToUpdateAndDeleteId.DataBind();
        }
    }
}