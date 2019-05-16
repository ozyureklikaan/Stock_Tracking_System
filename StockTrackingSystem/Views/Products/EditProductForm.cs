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

namespace StockTrackingSystem.Views.Products
{
    public partial class EditProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose The Product You Want To Edit");
                }
                txtBoxName.Text = (string)dataGridView.CurrentRow.Cells["Product Name"].Value;
                txtBoxPrice.Text = ((double)dataGridView.CurrentRow.Cells["Purchased Price"].Value).ToString();
                dateEditPuchasedDate.DateTime = (DateTime)dataGridView.CurrentRow.Cells["Purchased Date"].Value;
                string productType = (string)dataGridView.CurrentRow.Cells["Product Type"].Value;
                foreach (var item in comboBoxType.Properties.Items)
                {
                    if ((item.ToString()).Equals(productType))
                    {
                        comboBoxType.SelectedItem = item;
                    }
                }
                txtBoxQuantity.Text = ((int)dataGridView.CurrentRow.Cells["Quantity"].Value).ToString();
                txtBoxPurchasedCompany.Text = (string)dataGridView.CurrentRow.Cells["Purchased Company"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxName.Text) || string.IsNullOrEmpty(txtBoxPrice.Text) || string.IsNullOrEmpty(dateEditPuchasedDate.Text) || string.IsNullOrEmpty(comboBoxType.Text) || string.IsNullOrEmpty(txtBoxQuantity.Text) || string.IsNullOrEmpty(txtBoxPurchasedCompany.Text))
                {
                    throw new ValidationException("Please Check The Product Information You Entered");
                }
                if ((Convert.ToInt32(txtBoxPrice.Text)).Equals(0) || (Convert.ToInt32(txtBoxQuantity.Text)).Equals(0))
                {
                    throw new ValidationException("Price And Quantity Can Not Be Zero!");
                }
                ProductStockViewModel productStockVM = new ProductStockViewModel();
                productStockVM.product.productID = (int)dataGridView.CurrentRow.Cells["Product ID"].Value;
                productStockVM.product.productName = txtBoxName.Text;
                productStockVM.product.productPurchasePrice = Convert.ToInt32(txtBoxPrice.Text);
                productStockVM.product.productPurchaseDate = Convert.ToDateTime(dateEditPuchasedDate.Text);
                productStockVM.product.productType = comboBoxType.SelectedItem.ToString();
                productStockVM.product.purchasedCompany = txtBoxPurchasedCompany.Text;
                productStockVM.stock.stockID = (int)dataGridView.CurrentRow.Cells["Stock ID"].Value;
                productStockVM.stock.quantity = Convert.ToInt32(txtBoxQuantity.Text);
                AreYouSure(productStockVM);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AreYouSure(ProductStockViewModel productStockVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Save Changes?", "Changes Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', save changes
            {
                ProductController.EditProduct(productStockVM);
                SetDataGridView();
                MessageBox.Show("Your Product Changes Have Been Saved");
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to saving changes
            {
                MessageBox.Show("Give Up To Changes");
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
                e.Handled = true;           //If it is something else, block
            }
        }

        private void groupControlAddStock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}