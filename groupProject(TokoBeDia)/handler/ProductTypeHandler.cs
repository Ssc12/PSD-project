using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class ProductTypeHandler
    {
        public static void insertProductType(String name, String description)
        {
            ProductType newProductType = ProductTypeFactory.createProductType(name, description);
            ProductTypeRepository.insertProductType(newProductType);
        }

        public static void updateProductType(int id, String name, String description)
        {
            ProductTypeRepository.updateProductType(id, name, description);
        }
        public static void deleteProductType(int id)
        {
            ProductTypeRepository.deleteProductType(id);
        }
    }
}