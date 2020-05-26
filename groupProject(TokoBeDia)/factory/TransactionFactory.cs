using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction createHeaderTransaction(int userId, int paymentTypeId, DateTime date)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.UsersId = userId;
            ht.PaymentTypeId = paymentTypeId;
            ht.Date = date;

            return ht;
        }

        public static DetailTransaction createDetailTransaction(int headerTransactionId, int productId, int quantity)
        {
            DetailTransaction dt = new DetailTransaction();
            dt.HTransactionsId = headerTransactionId;
            dt.ProductsId = productId;
            dt.Quantity = quantity;

            return dt;
        }
    }
}