using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class TransactionRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static HeaderTransaction addHeaderTransaction(HeaderTransaction newHeaderTransaction)
        {
            db.HeaderTransactions.Add(newHeaderTransaction);
            db.SaveChanges();
            return newHeaderTransaction;
        }

        public static void addDetailTransaction(DetailTransaction newDetailTransaction)
        {
            db.DetailTransactions.Add(newDetailTransaction);
            db.SaveChanges();
        }

        public static List<HeaderTransaction> GetTransactions()
        {
            return db.HeaderTransactions.ToList();
        }
    }
}