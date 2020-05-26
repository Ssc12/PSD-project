using groupProject_TokoBeDia_.handler;
using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class TransactionController
    {
        public static void checkout(int userId, List<Cart> cartList, int paymentTypeId, DateTime date)
        {
            TransactionHandler.checkout(userId,cartList,paymentTypeId, date);
        }

        public static List<HeaderTransaction> GetTransactions()
        {
            return TransactionHandler.GetTransactions();
        }
    }
}