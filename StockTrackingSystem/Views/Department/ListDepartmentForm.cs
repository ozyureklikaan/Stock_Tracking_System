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

namespace StockTrackingSystem.Views.Department
{
    public partial class ListDepartmentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListDepartmentForm()
        {
            InitializeComponent();
        }

        private void ListDepartmentForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewDepartment();
        }

        private void barBtnListDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}