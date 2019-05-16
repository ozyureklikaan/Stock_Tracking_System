using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockTrackingSystem.Views.Users;
using StockTrackingSystem.Model;
using StockTrackingSystem.Controller;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;

namespace StockTrackingSystem
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public static int _personIDSession { get; set; }

        public static int _userIDSession { get; set; }

        public static int _accountTypeSession { get; set; }

        private const int DefaulValueForSessions = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void ResetAllSession()
        {
            _personIDSession = DefaulValueForSessions;
            _userIDSession = DefaulValueForSessions;
            _accountTypeSession = DefaulValueForSessions;
        }

        private void checkButtonAdmin_CheckedChanged(object sender, EventArgs e) => IsChecked(0);       //0 -> Admin Account

        private void checkButtonPersonnel_CheckedChanged(object sender, EventArgs e) => IsChecked(1);   //1 -> Personnel Account

        private void IsChecked(int accountType)
        {
            if (accountType == 0)
            {
                checkButtonPersonnel.Checked = false;
                if (checkButtonAdmin.Checked ==  true)
                {
                    lblAdmin.Visible = true;
                    lblPersonnel.Visible = false;
                }
                else
                {
                    lblAdmin.Visible = false;
                }
            }
            else if (accountType == 1)
            {
                checkButtonAdmin.Checked = false;
                if (checkButtonPersonnel.Checked == true)
                {
                    lblPersonnel.Visible = true;
                    lblAdmin.Visible = false;
                }
                else
                {
                    lblPersonnel.Visible = false;
                }
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e) => IsCheckedAccountType();

        private void IsCheckedAccountType()
        {
            try
            {
                if (checkButtonAdmin.Checked == false && checkButtonPersonnel.Checked == false)
                {
                    throw new ValidationException("Please Select User Account Type And Try Again!");
                }
                tblUsers user = new tblUsers();
                user.userName = txtBoxUserID.Text;
                user.password = txtBoxPassword.Text;
                string encryptedPassword = Encoder(user.password);
                if (string.IsNullOrEmpty(user.userName))
                {
                    throw new ValidationException("User Name Can Not Be Empty!");
                }
                else if (string.IsNullOrEmpty(encryptedPassword))
                {
                    throw new ValidationException("Password Can Not Be Empty");
                }
                else if (user.password.Length < 6)
                {
                    throw new ValidationException("Password Cannot Be Shorter Than 6 Digits!");
                }
                user.password = encryptedPassword;
                if (checkButtonAdmin.Checked == true)
                {
                    AdminLogin(user);
                }
                else if (checkButtonPersonnel.Checked == true)
                {
                    PersonnelLogin(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string Encoder(string password)
        {
            using (var context = new stockTrackingSystemEntities())
            {
                var result = context.sp_Encoder(password).ElementAtOrDefault(0);
                return result;
            }
        }

        private void AdminLogin(tblUsers user)
        {
            var resultUser = UserController.AdminLogin(user);
            _userIDSession = resultUser.userID;
            var resultPerson = PersonnelController.PersonFinder(_userIDSession);
            _personIDSession = resultPerson.personID;
            _accountTypeSession = UserController.TypeFinder(resultUser.userID);
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Hide();
        }

        private void PersonnelLogin(tblUsers user)
        {
            var resultUser = UserController.PersonnelLogin(user);
            _userIDSession = resultUser.userID;
            var resultPerson = PersonnelController.PersonFinder(_userIDSession);
            _personIDSession = resultPerson.personID;
            _accountTypeSession = UserController.TypeFinder(resultUser.userID);
            PersonnelMainForm personnelMainForm = new PersonnelMainForm();
            personnelMainForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void blockWhiteSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }
}
