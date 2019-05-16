using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackingSystem.Model;
using System.Data.Entity.Core.Objects;


namespace StockTrackingSystem.Controller
{
    public class DepartmentController
    {
        public static List<sp_ListDepartment_Result> ListDepartment()
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListDepartment().ToList();
                return result;
            }
        }
    }
}
