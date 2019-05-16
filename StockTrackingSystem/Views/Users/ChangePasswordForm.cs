using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockTrackingSystem.Controller;
using System.ComponentModel.DataAnnotations;
using StockTrackingSystem.Model;

namespace StockTrackingSystem.Views.Users
{
    public partial class ChangePasswordForm : DevExpress.XtraEditors.XtraForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            txtBoxNewPassword.Enabled = false;
            txtBoxNewPasswordAgain.Enabled = false;
            btnChange.Enabled = false;
            checkBtnSuccessfulOrFailNew.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtBoxNewPassword.Text).Equals(txtBoxNewPasswordAgain.Text))
                {
                    AreYouSure();
                    this.Close();
                }
                else
                {
                    throw new ValidationException("New Passwords Entered Are Not The Same");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "An Error Occurred!");
            }
            
        }

        private void AreYouSure()
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Change Current Password?", "Password Changing Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', password changed
            {
                string encryptedPassword = Encoder(txtBoxNewPassword.Text);
                UserController.ChangePassword(LoginForm._userIDSession, encryptedPassword);
                MessageBox.Show("Your Current Password Has Been Changed");
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to password changing
            {
                MessageBox.Show("Give Up To Current Password Changing");
            }
        }

        private void txtBoxCurrentPassword_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCurrentPassword.Text))
            {
                checkBtnSuccessfulOrFailCurrent.ImageOptions.Image = Properties.Resources.failIcon32x32;
                txtBoxNewPassword.Enabled = false;
                txtBoxNewPasswordAgain.Enabled = false;
                btnChange.Enabled = false;
            }
            else
            {
                string encryptedPassword = Encoder(txtBoxCurrentPassword.Text);
                if (UserController.CheckPassword(LoginForm._personIDSession, encryptedPassword) == true)
                {
                    checkBtnSuccessfulOrFailCurrent.ImageOptions.Image = Properties.Resources.successfullIcon32x32;
                    txtBoxNewPassword.Enabled = true;
                }
                else
                {
                    checkBtnSuccessfulOrFailCurrent.ImageOptions.Image = Properties.Resources.failIcon32x32;
                    txtBoxNewPassword.Enabled = false;
                    txtBoxNewPassword.Text = null;
                    txtBoxNewPasswordAgain.Enabled = false;
                    txtBoxNewPasswordAgain.Text = null;
                    checkBtnSuccessfulOrFailNew.ImageOptions.Image = Properties.Resources.failIcon32x32;
                    checkBtnSuccessfulOrFailNew.Visible = false;
                    btnChange.Enabled = false;
                }
            }
        }

        private void txtBoxNewPassword_EditValueChanged(object sender, EventArgs e)
        {
            if ((txtBoxNewPassword.Text).Length > 5)
            {
                txtBoxNewPasswordAgain.Enabled = true;
                if ((txtBoxNewPassword.Text).Equals(txtBoxNewPasswordAgain.Text))
                {
                    btnChange.Enabled = true;
                    checkBtnSuccessfulOrFailNew.ImageOptions.Image = Properties.Resources.successfullIcon32x32;
                    checkBtnSuccessfulOrFailNew.Visible = true;
                }
                else
                {
                    btnChange.Enabled = false;
                    checkBtnSuccessfulOrFailNew.ImageOptions.Image = Properties.Resources.failIcon32x32;
                }
            }
            else
            {
                txtBoxNewPasswordAgain.Enabled = false;
            }
        }

        private void txtBoxNewPasswordAgain_EditValueChanged(object sender, EventArgs e)
        {
            if ((txtBoxNewPasswordAgain.Text).Equals(txtBoxNewPassword.Text))
            {
                btnChange.Enabled = true;
                checkBtnSuccessfulOrFailNew.ImageOptions.Image = Properties.Resources.successfullIcon32x32;
                checkBtnSuccessfulOrFailNew.Visible = true;
            }
            else
            {
                btnChange.Enabled = false;
                checkBtnSuccessfulOrFailNew.ImageOptions.Image = Properties.Resources.failIcon32x32;
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
    }
}