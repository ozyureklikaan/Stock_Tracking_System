using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackingSystem.Model;
using System.Security.Authentication;

namespace StockTrackingSystem.Controller
{
    public class UserController
    {
        public static void ChangePassword(int personID, string newPassword)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                context.sp_ChangePassword(personID, newPassword);
                context.SaveChanges();
            }
        }

        public static Boolean CheckPassword(int userID, string currentPassword)
        {
            try
            {
                using (var context = new stockTrackingSystemEntities())
                {
                    var resultUser = context.tblUsers.FirstOrDefault(x => x.userID == userID);
                    if ((resultUser.password).Equals(currentPassword))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new AuthenticationException(ex.Message + "An Error Occurred!");
            }
            
        }

        public static tblUsers AdminLogin(tblUsers user)
        {
            CheckUserInformation(user);
            using (var context = new stockTrackingSystemEntities())
            {
                var wantedUser = context.tblUsers.FirstOrDefault(x => x.userName == user.userName && x.password == user.password);
                if (wantedUser == null)
                {
                    throw new AuthenticationException("User Information Is Invalid!");
                }

                var accountTypeID = context.tblUserType.FirstOrDefault(x => x.userID == wantedUser.userID);
                if (accountTypeID.typeID != (int)AccountTypes.administrator)
                {
                    throw new AuthenticationException("Unauthorized Account. Please Check Your Information And Try Again!");
                }
                return wantedUser;
            }
        }

        public static tblUsers PersonnelLogin(tblUsers user)
        {
            CheckUserInformation(user);
            using (var context = new stockTrackingSystemEntities())
            {
                var wantedUser = context.tblUsers.FirstOrDefault(x => x.userName == user.userName && x.password == user.password);
                if (wantedUser == null)
                {
                    throw new AuthenticationException("User Information Is Invalid!");
                }

                var accountTypeID = context.tblUserType.FirstOrDefault(x => x.userID == wantedUser.userID);
                if (accountTypeID.typeID == (int)AccountTypes.administrator)
                {
                    throw new AuthenticationException("You Are Logged In With Administrator Information. Please Select Account Type As Administrator!");
                }
                return wantedUser;
            }
        }

        private static void CheckUserInformation(tblUsers user)
        {
            if (string.IsNullOrEmpty(user.userName))
            {
                throw new AuthenticationException("User Name Can Not Be Empty!");
            }
            else if (string.IsNullOrEmpty(user.password))
            {
                throw new AuthenticationException("Password Can Not Be Empty!");
            }
            else if (user.password.Length < 6)
            {
                throw new AuthenticationException("Password Cannot Be Shorter Than 6 Digits!");
            }
        }

        public static tblUsers UserFinder(int userID)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.tblUsers.FirstOrDefault(x => x.userID == userID);
                return result;
            }
        }

        public static int TypeFinder(int userID)
        {
            int result = 0;
            using (var context = new stockTrackingSystemEntities())
            {
                var accountTypeID = context.tblUserType.FirstOrDefault(x => x.userID == userID);
                if (accountTypeID.typeID == (int)AccountTypes.administrator)
                {
                    result = (int)AccountTypes.administrator;
                }
                else if (accountTypeID.typeID == (int)AccountTypes.unitAuthority)
                {
                    result = (int)AccountTypes.unitAuthority;
                }
                else if (accountTypeID.typeID == (int)AccountTypes.personnel)
                {
                    result = (int)AccountTypes.personnel;
                }
            }
            return result;
        }
    }
}
