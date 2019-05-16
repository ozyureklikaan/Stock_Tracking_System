using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using StockTrackingSystem.Views.Users;
using StockTrackingSystem.Model;
using StockTrackingSystem.Controller;
using System.ComponentModel.DataAnnotations;

namespace StockTrackingSystem.Views.Personnel
{
    public partial class PersonnelDetailForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonnelDetailForm()
        {
            InitializeComponent();
        }

        private void PersonnelDetailForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewPersonnel();
            dataGridView.Columns["Person ID"].Visible = false;
        }


        private void barBtnListPesonnel_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(6);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(6);
            }
        }

        private void barBtnPersonnelDetail_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose The Person You Want To Show Person Detail");
                }
                txtBoxName.Text = (string)dataGridView.CurrentRow.Cells["Name"].Value;
                txtBoxLastName.Text = ((string)dataGridView.CurrentRow.Cells["Last Name"].Value).ToString();
                dateEditBirthDate.DateTime = (DateTime)dataGridView.CurrentRow.Cells["Birth Date"].Value;
                dateEditDateOfStart.DateTime = (DateTime)dataGridView.CurrentRow.Cells["Date Of Start"].Value;
                txtBoxActivityStatus.Text = SetActivityStatus();
                string department = (string)dataGridView.CurrentRow.Cells["Department"].Value;
                foreach (var item in comboBoxDepartment.Properties.Items)
                {
                    if ((item.ToString()).Equals(department))
                    {
                        comboBoxDepartment.SelectedItem = item;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string SetActivityStatus()
        {
            if (((Boolean)dataGridView.CurrentRow.Cells["Activity Status"].Value).Equals(true))
            {
                return "Active Staff";
            }
            else
            {
                return "Inactive Staff";
            }
        }
    }
}