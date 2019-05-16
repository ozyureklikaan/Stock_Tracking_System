using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackingSystem.Model;
using System.Data.Entity.Core.Objects;

namespace StockTrackingSystem.Controller
{
    public class DebitController
    {
        public static void AddDebit(ProductStockPersonViewModel debit)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_AddDebit(debit.product.productID, debit.person.personID, debit.debitedStock.debitedQuantity);
                context.SaveChanges();
            }
        }

        public static void DebitDeletion(DebitViewModel debit)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_DebitDeletion(debit.debit.debitID);
                context.SaveChanges();
            }
        }

        public static void EditDebit(DebitProductStockPersonViewModel debit)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_EditDebit(debit.debit.debitID, debit.product.productID, debit.person.personID, debit.stock.quantity);
                context.SaveChanges();
            }
        }

        public static List<sp_ListDebit_Result> ListDebit()
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListDebit().ToList();
                return result;
            }
        }

        public static List<sp_DebitedListOfDepartment_Result> DebitedListOfDepartment(int departmentID)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_DebitedListOfDepartment(departmentID).ToList();
                return result;
            }
        }

        public static List<sp_DebitedListOfPerson_Result> DebitedListOfPerson(int personID)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_DebitedListOfPerson(personID).ToList();
                return result;
            }
        }
    }
}
