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
    public partial class ViewTransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            gotoViewTransactionReportBtn.Visible = false;

            if(user.RolesId == 1)
            {
                refreshTransactionHistoryTableForAdmin();
                gotoViewTransactionReportBtn.Visible = true;
            }
            else if(user.RolesId == 2)
            {
                refreshTransactionHistoryTableForMember();
            }   
        }

        protected void refreshTransactionHistoryTableForMember()
        {
            User user = (User)Session["user"];
            int userId = user.UsersId;

            var hTdb = (from ht in TransactionRepository.db.HeaderTransactions.Where(ht => ht.UsersId == userId) select ht).ToList();
            var dTdb = (from dt in TransactionRepository.db.DetailTransactions.Where(dT => dT.HeaderTransaction.UsersId == userId) select dt).ToList();
            var joinTable = from ht in hTdb
                            join dt in dTdb
              on ht.HTransactionsId equals dt.HTransactionsId
                            select new
                            {
                                HeaderTransactionId = ht.HTransactionsId,
                                TransactionDate = ht.Date,
                                PaymentType = ht.PaymentType.Type,
                                ProductName = dt.Product.Name,
                                ProductQuantity = dt.Quantity,
                                SubTotal = (dt.Quantity * dt.Product.Price)
                            };

            viewTransactionHistoryTable.DataSource = joinTable;
            viewTransactionHistoryTable.DataBind();
        }

        protected void refreshTransactionHistoryTableForAdmin()
        {
            User user = (User)Session["user"];
            int userId = user.UsersId;

            var hTdb = (from ht in TransactionRepository.db.HeaderTransactions select ht).ToList();
            var dTdb = (from dt in TransactionRepository.db.DetailTransactions select dt).ToList();
            var joinTable = from ht in hTdb
                            join dt in dTdb
              on ht.HTransactionsId equals dt.HTransactionsId
                            select new
                            {
                                HeaderTransactionId = ht.HTransactionsId,
                                TransactionDate = ht.Date,
                                UserName = ht.User.Name,
                                PaymentType = ht.PaymentType.Type,
                                ProductName = dt.Product.Name,
                                ProductQuantity = dt.Quantity,
                                SubTotal = (dt.Quantity * dt.Product.Price)
                            };

            viewTransactionHistoryTable.DataSource = joinTable;
            viewTransactionHistoryTable.DataBind();
        }


        protected void gotoViewTransactionReportPg(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }
    }
}
