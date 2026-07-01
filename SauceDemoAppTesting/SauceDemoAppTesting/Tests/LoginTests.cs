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
            PerformLogin("koko_user", "invalidPass");
            var loginPage = new LoginPage(driver);
            string errorMassage = loginPage.GetErrorMessage();

            Assert.That(errorMassage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "User was able too log in");   
        }

        [Test]
        public void TestLoginWithLockedOutUser()
        {
            PerformLogin("locked_out_user", "secret_sauce");
            var loginPage = new LoginPage(driver);
            string errorMessage = loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test]

        public void TestLoginWithEmptyFields()
        {
            PerformLogin("", "");
            var loginPage = new LoginPage(driver);
            string errorMessage = loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username is required"));
        }
    }
}
