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

namespace StockTrackingSystem.Views.Personnel
{
    public partial class ListPersonnelForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListPersonnelForm()
        {
            InitializeComponent();
        }

        private void ListPersonnelForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewPersonnel();
            dataGridView.Columns["Person ID"].Visible = false;
        }

        private void barBtnListPersonnel_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnPersonnelDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(7);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(7);
            }
        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}