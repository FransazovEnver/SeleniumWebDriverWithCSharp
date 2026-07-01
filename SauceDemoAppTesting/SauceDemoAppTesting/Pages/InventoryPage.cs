using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By productTitle = By.XPath("//span[@class='title']");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public bool IsPageLoaded()
        {
            return GetText(productTitle) == "Products" && driver.Url.Contains("inventory.html");
        }
        
    }
}
