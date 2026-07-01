using SauceDemoAppTesting.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void SetUpToLogin()
        {
            PerformLogin("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryDisplay()
        {
            var inventoryPage = new InventoryPage(driver);

            Assert.That(inventoryPage.IsInvetoryDisplayed(), Is.True);
        }
    }
}
