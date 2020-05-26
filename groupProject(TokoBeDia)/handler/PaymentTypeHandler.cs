using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class PaymentTypeHandler
    {
        public static void insertPaymentType(String type)
        {
            PaymentType newPaymentType = PaymentTypeFactory.createPaymentType(type);
            PaymentTypeRepository.insertPaymentType(newPaymentType);
        }

        public static void updatePaymentType(int id, String type)
        {
            PaymentTypeRepository.updatePaymentType(id, type);
        }

        public static void deletePaymentType(int id)
        {
            PaymentTypeRepository.deletePaymentType(id);
        }
    }
}