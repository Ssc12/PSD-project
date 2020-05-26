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
    public partial class InsertProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doInsertProductType(object sender, EventArgs e)
        {
            String name = productTypeNameId.Text;
            String description = productTypeDescId.Text;

            ProductType pt = ProductTypeRepository.db.ProductTypes.Where(prodType => prodType.Name.Equals(name)).FirstOrDefault();
            String nameIsExist;

            try
            {
                nameIsExist = pt.Name;
            }
            catch
            {
                nameIsExist = "";
            }


            if (name.Length == 0)
            {
                errorMsgId.Text = "Please fill the product type name";
            }
            else if (name.Length < 5)
            {
                errorMsgId.Text = "Product type name must be 5 character or more";
            }
            else if (name.Equals(nameIsExist))
            {
                errorMsgId.Text = "Product type name is already exist, please input different type of product";
            }
            else if (description.Length == 0)
            {
                errorMsgId.Text = "Please fill the product type description";
            }
            else
            {
                ProductTypeController.insertProductType(name, description);
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}