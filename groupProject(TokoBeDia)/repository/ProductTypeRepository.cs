using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class ProductTypeRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void insertProductType(ProductType newProductType)
        {
            db.ProductTypes.Add(newProductType);
            db.SaveChanges();
        }

        public static void updateProductType(int id, String name, String description)
        {
            ProductType pt = db.ProductTypes.Where(prodType => prodType.ProductTypesId == id).FirstOrDefault();
            pt.Name = name;
            pt.Desciption = description;
            db.SaveChanges();
        }

        public static void deleteProductType(int id)
        {
            ProductType pt = db.ProductTypes.Where(prodType => prodType.ProductTypesId == id).FirstOrDefault();
            db.ProductTypes.Remove(pt);
            db.SaveChanges();
        }
    }
}