using SauceDemoAppTesting.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]

        public void TestLoginValidCredentials()
        {
            PerformLogin("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "Login was not succesfull");
        }

        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            PerformLogin("koko_user", "invalidPass"); //Epic sadface: Username and password do not match any user in this service

            var loginPage = new LoginPage(driver);
            string errorMassage = loginPage.GetErrorMessage();

            Assert.That(errorMassage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "User was able too log in");   

        }
    }
}
