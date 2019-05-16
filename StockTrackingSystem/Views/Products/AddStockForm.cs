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
    public partial class AddStockForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddStockForm()
        {
            InitializeComponent();
        }
        private void AddStockForm_Load(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.DataSource = DataController.SetDataGridViewAllProduct();
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

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose The Product You Want To Add Stock!");
                }
                if (string.IsNullOrEmpty(txtBoxQuantity.Text))
                {
                    throw new ValidationException("Please Enter Quantity You Want To Add!");
                }
                if (Convert.ToInt32(txtBoxQuantity.Text).Equals(0))
                {
                    throw new ValidationException("Amount To Add Can Not Be Zero!");
                }
                ProductStockViewModel productStockVM = new ProductStockViewModel();
                productStockVM.product.productID = (int)dataGridView.CurrentRow.Cells["Product ID"].Value;
                productStockVM.stock.quantity = Convert.ToInt32(txtBoxQuantity.Text);
                if (productStockVM.product.productID == 0)
                {
                    throw new ValidationException("Can Not Found Any Product");
                }
                AreYouSure(productStockVM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void AreYouSure(ProductStockViewModel productStockVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Amount To Add?", "Add Stock Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', quantity added
            {
                ProductController.AddStock(productStockVM);
                SetDataGridView();
                MessageBox.Show("Added Amount You Want To Add");
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to quantity adding
            {
                MessageBox.Show("Give Up To Adding");
            }
        }

        private void justNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;          //If number
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;          //If backspace
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}