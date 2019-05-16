using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Controller
{
    public class DataController
    {
        public static DataTable SetDataGridViewAllProduct()
        {
            var stockList = ProductController.ListAllProduct();
            DataTable dtAllProductList = new DataTable("Product List");
            dtAllProductList.Columns.Add("Product ID", typeof(int));
            dtAllProductList.Columns.Add("Product Name", typeof(string));
            dtAllProductList.Columns.Add("Purchased Price", typeof(double));
            dtAllProductList.Columns.Add("Purchased Date", typeof(DateTime));
            dtAllProductList.Columns.Add("Product Type", typeof(string));
            dtAllProductList.Columns.Add("Product Activity", typeof(bool));
            dtAllProductList.Columns.Add("Purchased Company", typeof(string));
            dtAllProductList.Columns.Add("Stock ID", typeof(int));
            dtAllProductList.Columns.Add("Quantity", typeof(int));
            foreach (var item in stockList)
            {
                dtAllProductList.Rows.Add(item.productID, item.productName, item.productPurchasePrice, item.productPurchaseDate, item.productType, item.productActivity, item.purchasedCompany, item.stockID, item.quantity);
            }
            return dtAllProductList;
        }

        public static DataTable SetDataGridViewProductsOfPersonnel(int personID)
        {
            var stockList = ProductController.ListMyProduct(personID);
            DataTable dtMyProductList = new DataTable("Product List");
            dtMyProductList.Columns.Add("Product ID", typeof(int));
            dtMyProductList.Columns.Add("Product Name", typeof(string));
            dtMyProductList.Columns.Add("Purchased Price", typeof(double));
            dtMyProductList.Columns.Add("Purchased Date", typeof(DateTime));
            dtMyProductList.Columns.Add("Product Type", typeof(string));
            dtMyProductList.Columns.Add("Product Activity", typeof(bool));
            dtMyProductList.Columns.Add("Purchased Company", typeof(string));
            dtMyProductList.Columns.Add("Debit ID", typeof(int));
            dtMyProductList.Columns.Add("Debited Quantity", typeof(int));
            foreach (var item in stockList)
            {
                dtMyProductList.Rows.Add(item.productID, item.productName, item.productPurchasePrice, item.productPurchaseDate, item.productType, item.productActivity, item.purchasedCompany, item.debitID, item.debitedQuantity);
            }
            return dtMyProductList;
        }

        public static DataTable SetDataGridViewActiveProducts()
        {
            var stockList = ProductController.ListActiveProducts();
            DataTable dtActiveProductList = new DataTable("Product List");
            dtActiveProductList.Columns.Add("Product ID", typeof(int));
            dtActiveProductList.Columns.Add("Product Name", typeof(string));
            dtActiveProductList.Columns.Add("Purchased Price", typeof(double));
            dtActiveProductList.Columns.Add("Purchased Date", typeof(DateTime));
            dtActiveProductList.Columns.Add("Product Type", typeof(string));
            dtActiveProductList.Columns.Add("Product Activity", typeof(bool));
            dtActiveProductList.Columns.Add("Purchased Company", typeof(string));
            dtActiveProductList.Columns.Add("Stock ID", typeof(int));
            dtActiveProductList.Columns.Add("Quantity", typeof(int));
            foreach (var item in stockList)
            {
                dtActiveProductList.Rows.Add(item.productID, item.productName, item.productPurchasePrice, item.productPurchaseDate, item.productType, item.productActivity, item.purchasedCompany, item.stockID, item.quantity);
            }
            return dtActiveProductList;
        }

        public static DataTable SetDataGridViewPersonnel()
        {
            var stockList = PersonnelController.ListPersonnel();
            DataTable dtAllPersonList = new DataTable("Product List");
            dtAllPersonList.Columns.Add("Person ID", typeof(int));
            dtAllPersonList.Columns.Add("Name", typeof(string));
            dtAllPersonList.Columns.Add("Last Name", typeof(string));
            dtAllPersonList.Columns.Add("Birth Date", typeof(DateTime));
            dtAllPersonList.Columns.Add("Date Of Start", typeof(DateTime));
            dtAllPersonList.Columns.Add("Activity Status", typeof(Boolean));
            dtAllPersonList.Columns.Add("Department", typeof(string));
            foreach (var item in stockList)
            {
                dtAllPersonList.Rows.Add(item.personID, item.personName, item.personLastName, item.personBirthDate, item.dateOfStart, item.activityStatus, item.departmentName);
            }
            return dtAllPersonList;
        }

        public static DataTable SetDataGridViewDepartment()
        {
            var stockList = DepartmentController.ListDepartment();
            DataTable dtDepartmentList = new DataTable("Department List");
            dtDepartmentList.Columns.Add("Department ID", typeof(int));
            dtDepartmentList.Columns.Add("Department Name", typeof(string));
            foreach (var item in stockList)
            {
                dtDepartmentList.Rows.Add(item.departmentID, item.departmentName);
            }
            return dtDepartmentList;
        }

        public static DataTable SetDataGridViewDebit()
        {
            var stockList = DebitController.ListDebit();
            DataTable dtDebitList = new DataTable("Product List");
            dtDebitList.Columns.Add("Product ID", typeof(int));
            dtDebitList.Columns.Add("Product Name", typeof(string));
            dtDebitList.Columns.Add("Purchased Price", typeof(double));
            dtDebitList.Columns.Add("Purchased Date", typeof(DateTime));
            dtDebitList.Columns.Add("Product Type", typeof(string));
            dtDebitList.Columns.Add("Purchased Company", typeof(string));
            dtDebitList.Columns.Add("Person ID", typeof(int));
            dtDebitList.Columns.Add("Person Name", typeof(string));
            dtDebitList.Columns.Add("Person Last Name", typeof(string));
            dtDebitList.Columns.Add("Department ID", typeof(int));
            dtDebitList.Columns.Add("Debit ID", typeof(int));
            dtDebitList.Columns.Add("Debited Stock ID", typeof(int));
            dtDebitList.Columns.Add("Debited Quantity", typeof(int));
            foreach (var item in stockList)
            {
                dtDebitList.Rows.Add(item.productID, item.productName, item.productPurchasePrice, item.productPurchaseDate, item.productType, item.purchasedCompany, item.personID, item.personName, item.personLastName, item.departmentID, item.debitID, item.debitedStockID, item.debitedQuantity);
            }
            return dtDebitList;
        }

        public static DataTable SetDataGridViewDebitedListOfPerson(int personID)
        {
            var stockList = DebitController.DebitedListOfPerson(LoginForm._personIDSession);
            DataTable dtDebitList = new DataTable("Product List");
            dtDebitList.Columns.Add("Person Name", typeof(string));
            dtDebitList.Columns.Add("Product ID", typeof(int));
            dtDebitList.Columns.Add("Product Name", typeof(string));
            dtDebitList.Columns.Add("Purchased Price", typeof(double));
            dtDebitList.Columns.Add("Purchased Date", typeof(DateTime));
            dtDebitList.Columns.Add("Product Type", typeof(string));
            dtDebitList.Columns.Add("Purchased Company", typeof(string));
            foreach (var item in stockList)
            {
                dtDebitList.Rows.Add(item.Person_Name, item.productID, item.productName, item.productPurchasePrice, item.productPurchaseDate, item.productType, item.purchasedCompany);
            }
            return dtDebitList;
        }
    }
}
