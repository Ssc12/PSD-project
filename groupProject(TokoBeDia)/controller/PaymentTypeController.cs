
using groupProject_TokoBeDia_.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class PaymentTypeController
    {
        public static void insertPaymentType(String type)
        {
            PaymentTypeHandler.insertPaymentType(type);
        }

        public static void updatePaymentType(int id, String type)
        {
            PaymentTypeHandler.updatePaymentType(id, type);
        }

        public static void deletePaymentType(int id)
        {
            PaymentTypeHandler.deletePaymentType(id);
        }
    }
}