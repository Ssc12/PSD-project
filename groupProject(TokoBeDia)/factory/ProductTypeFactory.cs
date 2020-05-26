using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class ProductTypeFactory
    {
        public static ProductType createProductType(String name, String description)
        {
            ProductType pt = new ProductType();
            pt.Name = name;
            pt.Desciption = description;

            return pt;
        }
    }
}