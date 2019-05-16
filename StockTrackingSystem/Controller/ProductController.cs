using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackingSystem.Model;
using System.Data.Entity.Core.Objects;
using System.ComponentModel.DataAnnotations;

namespace StockTrackingSystem.Controller
{
    public static class ProductController
    {
        public static void AddProduct(ProductStockViewModel product)
        {
            if(product == null)
            {
                throw new ValidationException("Invalid Product Information");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_AddProduct(product.product.productName, product.product.productPurchasePrice, product.product.productPurchaseDate, product.product.productType, product.stock.quantity, product.product.purchasedCompany);
                context.SaveChanges();
            }
        }

        public static void AddStock(ProductStockViewModel product)
        {
            if (product == null)
            {
                throw new ValidationException("Invalid Product Information");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_AddStock(product.product.productID, product.stock.quantity);
                context.SaveChanges();
            }
        }

        public static void EditProduct(ProductStockViewModel product)
        {
            if (product == null)
            {
                throw new ValidationException("Product Not Found");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_EditProduct(product.product.productID, product.product.productName, product.product.productPurchasePrice, product.product.productPurchaseDate, product.product.productType, product.product.purchasedCompany, product.stock.quantity);
                context.SaveChanges();
            }
        }

        public static void ProductDeletion(ProductViewModel product)
        {
            if (product.product.productID == 0)
            {
                throw new ValidationException("Invalid Product Information");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_ProductDeletion(product.product.productID);
                context.SaveChanges();
            }
        }

        public static List<sp_ListAllProducts_Result> ListAllProduct()
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListAllProducts().ToList();
                return result;
            }
        }

        public static List<sp_ListProducts_Result> ListActiveProducts()
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListProducts().ToList();
                return result;
            }
        }

        public static List<sp_ListMyProducts_Result> ListMyProduct(int personID)
        {
            if (personID == 0)
            {
                throw new ValidationException("Person Not Found");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListMyProducts(personID).ToList();
                return result;
            }
        }
    }
}
