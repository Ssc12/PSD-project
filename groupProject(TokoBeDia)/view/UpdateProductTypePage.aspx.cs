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
    public partial class UpdateProductTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductType pt = ProductTypeRepository.db.ProductTypes.Where(prodType => prodType.ProductTypesId == id).FirstOrDefault();
            toBeUpdateProductTypeName.Text = pt.Name;
            toBeUpdateProductTypeDesc.Text = pt.Desciption;
        }

        protected void doUpdateProductType(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            String name = updateProductTypeNameId.Text;
            String description = updateProductTypeDescId.Text;

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
                errorMsgId.Text = "Product type name is already exist, please input different type of product";  // mungkin perlu dire-validate
            }
            else if (description.Length == 0)
            {
                errorMsgId.Text = "Please fill the product type description";
            }
            else
            {
                ProductTypeController.updateProductType(id, name, description);
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}