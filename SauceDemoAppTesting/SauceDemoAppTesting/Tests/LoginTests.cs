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
    }
}
