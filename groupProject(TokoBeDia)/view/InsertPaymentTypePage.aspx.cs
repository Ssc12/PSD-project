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
    public partial class InsertPaymentTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doInsertPaymentType(object sender, EventArgs e)
        {
            String type = paymentTypeNameId.Text;

            PaymentType pt = PaymentTypeRepository.db.PaymentTypes.Where(payType => payType.Type.Equals(type)).FirstOrDefault();
            String paymentTypeIsExist;

            try
            {
                paymentTypeIsExist = pt.Type;
            }
            catch
            {
                paymentTypeIsExist = "";
            }


            if (type.Length == 0)
            {
                errorMsgId.Text = "Please fill the payment type name";
            }
            else if (type.Length < 3)
            {
                errorMsgId.Text = "Payment type name must be 3 character or more";
            }
            else if (type.Equals(paymentTypeIsExist))
            {
                errorMsgId.Text = "Payment type name is already exist, please input different type of payment";
            }
            else
            {
                PaymentTypeController.insertPaymentType(type);
                Response.Redirect("ViewPaymentType.aspx");
            }
        }
    }
}