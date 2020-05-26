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
    public partial class UpdatePaymentTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            PaymentType pt = PaymentTypeRepository.db.PaymentTypes.Where(payType => payType.PaymentTypesId == id).FirstOrDefault();
            toBeUpdatePaymentTypeName.Text = pt.Type;
        }

        protected void doUpdatePaymenttType(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            String type = updatePaymentTypeNameId.Text;

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
                errorMsgId.Text = "updated payment type name must be 3 character or more";
            }
            else if (type.Equals(paymentTypeIsExist))
            {
                errorMsgId.Text = "Payment type name is already exist, please input different type of payment"; //mungin perlu di re-validate
            }else
            {
                PaymentTypeController.updatePaymentType(id, type);
                Response.Redirect("ViewPaymentType.aspx");
            }
        }
    }
}