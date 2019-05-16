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
using StockTrackingSystem.Controller;
using StockTrackingSystem.Model;
using System.ComponentModel.DataAnnotations;

namespace StockTrackingSystem.Views.Debit
{
    public partial class DebitDeletionForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DebitDeletionForm()
        {
            InitializeComponent();
        }

        private void DebitDeletionForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewDebit();
            dataGridView.Columns["Product ID"].Visible = false;
            dataGridView.Columns["Person ID"].Visible = false;
            dataGridView.Columns["Department ID"].Visible = false;
            dataGridView.Columns["Debit ID"].Visible = false;
            dataGridView.Columns["Debited Stock ID"].Visible = false;
        }

        private void barBtnAddDebit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(9);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(9);
            }
        }

        private void barBtnDebitDeletion_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnEditDebit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(11);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(11);
            }
        }

        private void barBtnListDebit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(12);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(12);
            }
        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose A Debit For Deletion!");
                }
                DebitViewModel debitVM = new DebitViewModel();
                debitVM.debit.debitID = (int)dataGridView.CurrentRow.Cells["Debit ID"].Value;
                AreYouSure(debitVM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AreYouSure(DebitViewModel debitVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Deletion?", "Deletion Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', debit delete
            {
                DebitController.DebitDeletion(debitVM);
                MessageBox.Show("Deleted Debit You Want To Deletion");
                SetDataGridView();      //For refres
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to deletion
            {
                MessageBox.Show("Give Up To Deletion");
            }
        }
    }
}