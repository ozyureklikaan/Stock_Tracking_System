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

namespace StockTrackingSystem.Views.Products
{
    public partial class ProductDeletionForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProductDeletionForm()
        {
            InitializeComponent();
        }
        private void ProductDeletionForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewActiveProducts();
            dataGridView.Columns["Product ID"].Visible = false;
            dataGridView.Columns["Stock ID"].Visible = false;
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

        }

        private void barBtnListProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginForm._accountTypeSession.Equals(1))
            {
                AdminMainForm.FormRouter(5);
            }
            else if (LoginForm._accountTypeSession.Equals(2) || LoginForm._accountTypeSession.Equals(3))
            {
                PersonnelMainForm.FormRouter(5);
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
                    throw new ValidationException("Please Choose The Product You Want To Delete!");
                }
                ProductViewModel productStockVM = new ProductViewModel();
                productStockVM.product.productID = (int)dataGridView.CurrentRow.Cells["Product ID"].Value;
                AreYouSure(productStockVM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AreYouSure(ProductViewModel productStockVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete?", "Deletion Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', product deleted
            {
                ProductController.ProductDeletion(productStockVM);
                SetDataGridView();
                MessageBox.Show("Deleted The Product You Want To Delete");
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to product delete
            {
                MessageBox.Show("Give Up To Deletion");
            }
        }
    }
}