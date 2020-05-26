using groupProject_TokoBeDia_.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class ProductTypeController
    {
        public static void insertProductType(String name, String description)
        {
            ProductTypeHandler.insertProductType(name, description);
        }

        public static void updateProductType(int id, String name, String description)
        {
            ProductTypeHandler.updateProductType(id, name, description);
        }

        public static void deleteProductType(int id)
        {
            ProductTypeHandler.deleteProductType(id);
        }
    }
}