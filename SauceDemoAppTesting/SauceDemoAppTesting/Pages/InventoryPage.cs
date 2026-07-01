using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By CartLink = By.XPath("//a[@class='shopping_cart_link']");
        private readonly By ProductTitle = By.XPath("//span[@class='title']");
        private readonly By InventoryItems = By.XPath("//div[@class='inventory_item']");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public bool IsPageLoaded()
        {
            return GetText(ProductTitle) == "Products" && driver.Url.Contains("inventory.html");
        }

        public void AddItemToCartIndex(int itemIndex)
        {
            var itemToAddTooCart = By.XPath($"(//div[@class='inventory_item'])[{itemIndex}]//div//button");
            Click(itemToAddTooCart);
        }

        public void AddToCartByName()
        {
            var itemToAdd = By.XPath("//div[text()='Sauce Labs Backpack']/ancestor::div[@class='inventory_item']//button");
            Click(itemToAdd);
        }

        public void ClickCartLink()
        {
            Click(CartLink);
        }

        public bool IsInvetoryDisplayed()
        {
            return FindElements(InventoryItems).Any();
        }
    }
}
