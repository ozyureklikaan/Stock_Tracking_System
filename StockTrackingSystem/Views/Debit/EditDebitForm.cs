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
    public partial class EditDebitForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EditDebitForm()
        {
            InitializeComponent();
        }

        private void EditDebitForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridViews();
        }

        private void RefreshDataGridViews()
        {
            SetDataGridViewDebit();
            SetDataGridViewProduct();
            SetDataGridViewPersonnel();
        }

        private void SetDataGridViewDebit()
        {
            dataGridViewDebit.DataSource = DataController.SetDataGridViewDebit();
            dataGridViewDebit.Columns["Product ID"].Visible = false;
            dataGridViewDebit.Columns["Person ID"].Visible = false;
            dataGridViewDebit.Columns["Department ID"].Visible = false;
            dataGridViewDebit.Columns["Debit ID"].Visible = false;
            dataGridViewDebit.Columns["Debited Stock ID"].Visible = false;
        }

        private void SetDataGridViewProduct()
        {
            dataGridViewProduct.DataSource = DataController.SetDataGridViewAllProduct();
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDebit.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose A Debit For Edit!");
                }
                if (dataGridViewProduct.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose A Product For Edit!");
                }
                if (dataGridViewPersonnel.CurrentRow == null)
                {
                    throw new ValidationException("Please Choose Personnel For Edit!");
                }
                if ((txtBoxQuantity.Text).Equals("0"))
                {
                    throw new ValidationException("Quantity Can Not Be Zero!");
                }
                if (Convert.ToInt32(txtBoxQuantity.Text) > (int)dataGridViewProduct.CurrentRow.Cells["Quantity"].Value)
                {
                    throw new ValidationException("Product Stock Is Not Enough ");
                }
                DebitProductStockPersonViewModel debitProductStockPersonVM = new DebitProductStockPersonViewModel();
                debitProductStockPersonVM.debit.debitID = (int)dataGridViewDebit.CurrentRow.Cells["Debit ID"].Value;
                debitProductStockPersonVM.product.productID = (int)dataGridViewProduct.CurrentRow.Cells["Product ID"].Value;
                debitProductStockPersonVM.person.personID = (int)dataGridViewPersonnel.CurrentRow.Cells["Person ID"].Value;
                debitProductStockPersonVM.stock.quantity = Convert.ToInt32(txtBoxQuantity.Text);
                AreYouSure(debitProductStockPersonVM);
                foreach (var item in ProductController.ListActiveProducts())
                {
                    if (item.quantity.Equals(0) && item.productID.Equals(debitProductStockPersonVM.product.productID))
                    {

                        IsItStockEmpty(debitProductStockPersonVM.product.productID);
                    }
                }
                RefreshDataGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AreYouSure(DebitProductStockPersonViewModel debitProductStockPersonVM)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Edit?", "Edit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)           //If click 'Yes', debit edited
            {
                DebitController.EditDebit(debitProductStockPersonVM);
                MessageBox.Show("Edited The Debit You Want To Edit");
                RefreshDataGridViews();     //For refres
            }
            else if (dialogResult == DialogResult.No)       //If click 'No', give up to editing
            {
                MessageBox.Show("Give Up To Editing");
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