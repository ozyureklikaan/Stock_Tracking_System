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
    public partial class AddProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {

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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxName.Text) || txtBoxPrice.Text == null || string.IsNullOrEmpty(dateEditPuchasedDate.Text) || (comboBoxType.SelectedItem.ToString()).Equals("Select Type") || txtBoxQuantity.Text == null || string.IsNullOrEmpty(txtBoxPurchasedCompany.Text))
                {
                    throw new ValidationException("Check Your Product Informations. Product Informations Should Not Be Empty!");
                }
                if (Convert.ToInt32(txtBoxPrice.Text).Equals(0))
                {
                    throw new ValidationException("Price Can Not Be Zero");
                }
                if (Convert.ToInt32(txtBoxQuantity.Text).Equals(0))
                {
                    throw new ValidationException("Quantity Can Not Be Zero");
                }
                ProductStockViewModel productStockVM = new ProductStockViewModel();
                productStockVM.product.productName = txtBoxName.Text;
                productStockVM.product.productPurchasePrice = Convert.ToDecimal(txtBoxPrice.Text);
                productStockVM.product.productPurchaseDate = Convert.ToDateTime(dateEditPuchasedDate.Text);
                productStockVM.product.productType = comboBoxType.SelectedItem.ToString();
                productStockVM.stock.quantity = Convert.ToInt32(txtBoxQuantity.Text);
                productStockVM.product.purchasedCompany = txtBoxPurchasedCompany.Text;
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
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', product added
            {
                ProductController.AddProduct(productStockVM);
                MessageBox.Show("Added Product You Want To Add");
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to product adding
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