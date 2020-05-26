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
    public partial class ViewUpdateAndDeleteProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void updateRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateProductTypePage.aspx?id=" + id);
        }

        protected void deleteRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);

            ProductType pt = ProductTypeRepository.db.ProductTypes.Where(prodType => prodType.ProductTypesId == id).FirstOrDefault();
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductTypeId == id).FirstOrDefault();

            int idIsUseOnProduct;
            try
            {
                idIsUseOnProduct = p.ProductTypeId;
            }
            catch
            {
                idIsUseOnProduct = 0;
            }


            if (idIsUseOnProduct == pt.ProductTypesId)
            {
                validateDeleteIsReferencesID.Text = "Product Type cannot be delete because it reference on other table";
            }
            else
            {
                ProductTypeController.deleteProductType(id);
                refreshTable();
            }


        }

        protected void refreshTable()
        {
            productTypeListToUpdateAndDeleteId.DataSource = ProductTypeRepository.db.ProductTypes.ToList();
            productTypeListToUpdateAndDeleteId.DataBind();
        }
    }
}