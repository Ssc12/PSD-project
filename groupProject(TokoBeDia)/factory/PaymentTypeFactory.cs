using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class PaymentTypeFactory
    {
        public static PaymentType createPaymentType(String type)
        {
            PaymentType pt = new PaymentType();
            pt.Type = type;

            return pt;
        }
    }
}