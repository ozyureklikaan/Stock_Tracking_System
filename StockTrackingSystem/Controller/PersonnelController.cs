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
    public class PersonnelController
    {
        public static List<sp_ListPersonnel_Result> ListPersonnel()
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_ListPersonnel().ToList();
                return result;
            }
        }

        public static sp_PersonnelDetail_Result PersonnelDetail(int personID)
        {
            if (personID == 0)
            {
                throw new ValidationException("Person Not Found");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_PersonnelDetail(personID).ElementAtOrDefault(0);
                return result;
            }
        }

        public static tblPersons PersonFinder(int userID)
        {
            if (userID == 0)
            {
                throw new ValidationException("User Not Found");
            }

            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.tblPersons.FirstOrDefault(x => x.userID == userID);
                return result;
            }
        }
    }
}
