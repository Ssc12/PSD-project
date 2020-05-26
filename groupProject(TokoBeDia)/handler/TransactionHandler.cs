using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class TransactionHandler
    {

        public static void checkout(int userId, List<Cart> cartList, int paymentTypeId, DateTime date)
        {
            HeaderTransaction newHT = TransactionFactory.createHeaderTransaction(userId, paymentTypeId, date);
            int htId = TransactionRepository.addHeaderTransaction(newHT).HTransactionsId;

            foreach(Cart cart in cartList){
                 DetailTransaction newDT = TransactionFactory.createDetailTransaction(htId, cart.ProductsId, cart.Quantity);
                 TransactionRepository.addDetailTransaction(newDT);
            }     
        }

        public static List<HeaderTransaction> GetTransactions()
        {
            return TransactionRepository.GetTransactions();
        }
    }
}