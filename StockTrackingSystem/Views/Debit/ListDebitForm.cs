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
    public partial class ListDebitForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListDebitForm()
        {
            InitializeComponent();
        }

        private void ListDebitForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._accountTypeSession.Equals(3))
            {
                barBtnAddDebit.Dispose();

                barBtnDebitDeletion.Dispose();

                barBtnEditDebit.Dispose();

                barBtnListDebit.Caption = "List My Debitting";

                btnListAllDebits.Visible = false;

                btnListMyDebits.Visible = false;

                btnListMyDebitsForPersonnel.Visible = true;
            }
            else
            {
                btnListAllDebits.Visible = true;

                btnListMyDebits.Visible = true;

                btnListMyDebitsForPersonnel.Visible = false;
            }
        }

        private void SetDataGridViewForPersonnel()
        {
            dataGridView.DataSource = DataController.SetDataGridViewDebitedListOfPerson(LoginForm._personIDSession);
            dataGridView.Columns["Product ID"].Visible = false;
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
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(10);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(10);
            }
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

        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnListMyDebitsForPersonnel_Click(object sender, EventArgs e)
        {
            SetDataGridViewForPersonnel();
        }

        private void btnListAllDebits_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void btnListMyDebits_Click(object sender, EventArgs e)
        {
            SetDataGridViewForPersonnel();
        }
    }
}