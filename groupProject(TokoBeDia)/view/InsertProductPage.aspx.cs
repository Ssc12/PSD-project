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
    public partial class InsertProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }


        protected void doInsertProduct(object sender, EventArgs e)
        {

            String name = productNameId.Text;
            String productTypeName = productTypeNameId.Text;
                int stock;
                try
                {
                    stock = Int32.Parse(productStockId.Text);
                }
                catch
                {
                    stock = 0;
                }

                int price;
                try
                {
                    price = Int32.Parse(productPriceId.Text);
                }
                catch
                {
                    price = 1;
                }


            ProductType pt = ProductTypeRepository.db.ProductTypes.Where(prodType => prodType.Name.Equals(productTypeName)).FirstOrDefault();
                String ptName;
                try
                {
                    ptName = pt.Name;
                }
                catch
                {
                    ptName = "";
                }

            Product p = ProductRepository.db.Products.Where(prod => prod.Name.Equals(name)).FirstOrDefault();
                String productNameIsUsed;
                try
                {
                    productNameIsUsed = p.Name;
                }
                catch
                {
                    productNameIsUsed = "";
                }

            if (name.Equals(productNameIsUsed))
            {
                errorMsgId.Text = "product name is already taken, please input different product";
            }
            else if (stock < 1)
            {
                errorMsgId.Text = "insert at least one product stock";
            }
            else if (price <= 1000 && price % 1000 != 0)
            {
                errorMsgId.Text = "price must be above 1000 and multiply of 1000";
            }
            else if (productTypeName.Length == 0)
            {
                errorMsgId.Text = "fill the product name";
            }
            else if (!ptName.Equals(productTypeName))
            {
                errorMsgId.Text = "Product Type doesn't exist";
            }
            else
            {
                int productTypeId = pt.ProductTypesId;
                ProductController.insertProduct(name, stock, price, productTypeId);
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}