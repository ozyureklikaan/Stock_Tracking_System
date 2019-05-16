using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockTrackingSystem.Controller;
using StockTrackingSystem.Model;

namespace StockTrackingSystemTests.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(AuthenticationException))]
        public void AdminLogin()
        {
            var user = new tblUsers();
            UserController.AdminLogin(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AddProduct()
        {
            ProductStockViewModel productStockVM = null;
            ProductController.AddProduct(productStockVM);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AddStock()
        {
            ProductStockViewModel productStockVM = null;
            ProductController.AddStock(productStockVM);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void ListMyProducts()
        {
            ProductController.ListMyProduct(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void PersonnelDetail()
        {
            int personID = 0;
            PersonnelController.PersonnelDetail(personID);
        }
    }
}
