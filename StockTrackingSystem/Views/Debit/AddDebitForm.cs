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
    public partial class AddDebitForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddDebitForm()
        {
            InitializeComponent();
        }

        private void AddDebitForm_Load(object sender, EventArgs e)
        {
            SetDataGridViewProduct();
            SetDataGridViewPersonnel();
        }

        private void SetDataGridViewProduct()
        {
            dataGridViewProduct.DataSource = DataController.SetDataGridViewActiveProducts();
            dataGridViewProduct.Columns["Product ID"].Visible = false;
            dataGridViewProduct.Columns["Stock ID"].Visible = false;
        }

        private void SetDataGridViewPersonnel()
        {
            dataGridViewPersonnel.DataSource = DataController.SetDataGridViewPersonnel();
            dataGridViewPersonnel.Columns["Person ID"].Visible = false;
        }

        private void barBtnAddDebit_ItemClick(object sender, ItemClickEventArgs e)
        {

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

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxProductName.Text = (string)dataGridViewProduct.CurrentRow.Cells["Product Name"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxPersonnelName.Text = (string)dataGridViewPersonnel.CurrentRow.Cells["Name"].Value + " " + (string)dataGridViewPersonnel.CurrentRow.Cells["Last Name"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDebiting_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProduct.CurrentRow == null || dataGridViewPersonnel.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose Product And Personnel For Debiting!");
                }
                if (string.IsNullOrEmpty(txtBoxQuantity.Text))
                {
                    throw new ValidationException("Quantity Can Not Be Empty!");
                }
                if ((txtBoxQuantity.Text).Equals("0"))
                {
                    throw new ValidationException("Quantity Can Not Be Zero!");
                }
                if (Convert.ToInt32(txtBoxQuantity.Text) > (int)dataGridViewProduct.CurrentRow.Cells["Quantity"].Value)
                {
                    throw new ValidationException("Product Stock Is Not Enough ");
                }
                ProductStockPersonViewModel productStockPersonVM = new ProductStockPersonViewModel();
                productStockPersonVM.product.productID = (int)dataGridViewProduct.CurrentRow.Cells["Product ID"].Value;
                productStockPersonVM.person.personID = (int)dataGridViewPersonnel.CurrentRow.Cells["Person ID"].Value;
                productStockPersonVM.debitedStock.debitedQuantity = Convert.ToInt32(txtBoxQuantity.Text);
                AreYouSure(productStockPersonVM);
                foreach (var item in ProductController.ListActiveProducts())
                {
                    if (item.quantity.Equals(0) && item.productID.Equals(productStockPersonVM.product.productID))
                    {

                        IsItStockEmpty(productStockPersonVM.product.productID);
                    }
                }
                SetDataGridViewProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AreYouSure(ProductStockPersonViewModel productStockPersonVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Debiting?", "Debiting Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', product debited
            {
                DebitController.AddDebit(productStockPersonVM);
                MessageBox.Show("Debited The Product You Want To Debiting");
                SetDataGridViewProduct();
                SetDataGridViewPersonnel();
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to debiting
            {
                MessageBox.Show("Give Up To Debiting");
            }
        }

        private void IsItStockEmpty(int productID)
        {
            ProductViewModel productVM = new ProductViewModel();
            productVM.product.productID = productID;
            ProductController.ProductDeletion(productVM);
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