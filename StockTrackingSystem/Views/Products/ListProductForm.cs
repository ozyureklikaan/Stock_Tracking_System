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

namespace StockTrackingSystem.Views.Products
{
    public partial class ListProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListProductForm()
        {
            InitializeComponent();
        }

        private void ListProductForm_Load(object sender, EventArgs e)
        {
            btnRefreshMyList.Enabled = false;
            btnRefreshMyList.Visible = false;

            if (LoginForm._accountTypeSession.Equals(3))
            {
                barBtnAddProduct.Dispose();

                barBtnAddStock.Dispose();

                barBtnEditProduct.Dispose();

                barBtnProductDeletion.Dispose();

                barBtnListProduct.Caption = "List My Products";

                btnRefreshMyList.Enabled = true;
                btnRefreshMyList.Visible = true;

                btnListMyProducts.Enabled = false;
                btnListMyProducts.Visible = false;

                btnListAllProducts.Enabled = false;
                btnListAllProducts.Visible = false;

                SetDataGridViewForPersonnel(LoginForm._personIDSession);
            }
        }
        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewAllProduct();
            dataGridView.Columns["Product ID"].Visible = false;
            dataGridView.Columns["Stock ID"].Visible = false;
        }

        private void SetDataGridViewForPersonnel(int personID)
        {
            dataGridView.DataSource = DataController.SetDataGridViewProductsOfPersonnel(personID);
            dataGridView.Columns["Product ID"].Visible = false;
            dataGridView.Columns["Debit ID"].Visible = false;
        }

        private void barBtnAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(1);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(1);
            }
        }

        private void barBtnAddStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(2);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(2);
            }
        }

        private void barBtnEditProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(3);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(3);
            }
        }

        private void barBtnProductDeletion_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(4);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(4);
            }
        }

        private void barBtnListProduct_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefreshMyList_Click(object sender, EventArgs e)
        {
            SetDataGridViewForPersonnel(LoginForm._personIDSession);
        }

        private void btnListMyProducts_Click(object sender, EventArgs e)
        {
            SetDataGridViewForPersonnel(LoginForm._personIDSession);
        }

        private void btnListAllProducts_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }
    }
}