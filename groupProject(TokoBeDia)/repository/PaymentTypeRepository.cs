using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class PaymentTypeRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void insertPaymentType(PaymentType newPaymentType)
        {
            db.PaymentTypes.Add(newPaymentType);
            db.SaveChanges();
        }

        public static void updatePaymentType(int id, String type)
        {
            PaymentType pt = db.PaymentTypes.Where(payType => payType.PaymentTypesId == id).FirstOrDefault();
            pt.Type = type;
            db.SaveChanges();
        }

        public static void deletePaymentType(int id)
        {
            PaymentType pt = db.PaymentTypes.Where(payType => payType.PaymentTypesId == id).FirstOrDefault();
            db.PaymentTypes.Remove(pt);
            db.SaveChanges();
        }
    }
}