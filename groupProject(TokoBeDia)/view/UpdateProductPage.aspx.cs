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
    public partial class UpdateProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            int id = Int32.Parse(Request.QueryString["id"]);
            Product p = ProductRepository.db.Products.Where(prod => prod.ProductsId == id).FirstOrDefault();
            toBeUpdatedProductName.Text = p.Name;
            toBeUpdatedProductStock.Text = p.Stock.ToString();
            toBeUpdatedProductPrice.Text = p.Price.ToString();
            toBeUpdatedProductType.Text = p.ProductType.Name;
        }

        protected void doUpdateProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            String name = updateProductNameId.Text;
            String productTypeName = productTypeNameId.Text;

                int stock;
                try
                {
                    stock = Int32.Parse(updateProductStockId.Text);
                }
                catch
                {
                    stock = 0;
                }

                int price;
                try
                {
                    price = Int32.Parse(updateProductPriceId.Text);
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

            if(name.Length == 0)
            {
                errorMsgId.Text = "please fill the product name";
            }
            else if (name.Equals(productNameIsUsed))
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
                ProductController.updateProduct(id, name, stock, price, productTypeId);
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}