using groupProject_TokoBeDia_.controller;
using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport newReport = new CrystalReport();
            newReport.SetDataSource(GetDataset(TransactionController.GetTransactions()));

            DTReportViewer.ReportSource = newReport;
        }


        public DataSet GetDataset(List<HeaderTransaction> transactionList)
        {
            DataSet ds = new DataSet();
            var headerTransaction = ds.HeaderTransaction;
            var detailTransaction = ds.DetailTransaction;
            var grandTotalTransaction = ds.GrandTotalTransaction;
            foreach (var ht in transactionList)
            {
                var headerRow = headerTransaction.NewRow();

                headerRow["TransactionId"] = ht.HTransactionsId;
                headerRow["Date"] = ht.Date;
                headerRow["Username"] = ht.User.Name;
                headerRow["PaymentType"] = ht.PaymentType.Type;

                headerTransaction.Rows.Add(headerRow);
                int grandtotal = 0;
                foreach (var dt in ht.DetailTransactions)
                {
                    var detailRow = detailTransaction.NewRow();

                    detailRow["TransactionId"] = dt.HTransactionsId;
                    detailRow["ProductName"] = dt.Product.Name;
                    detailRow["ProductPrice"] = dt.Product.Price;
                    detailRow["Quantity"] = dt.Quantity;
                    detailRow["Subtotal"] = (dt.Quantity * dt.Product.Price);
                    grandtotal = grandtotal + (dt.Quantity * dt.Product.Price);
                    detailTransaction.Rows.Add(detailRow);
                }
                var gtRow = grandTotalTransaction.NewRow();
                gtRow["TransactionId"] = ht.HTransactionsId;
                gtRow["GrandTotal"] = grandtotal;
                grandTotalTransaction.Rows.Add(gtRow);
            }

            return ds;
        }
    }
}