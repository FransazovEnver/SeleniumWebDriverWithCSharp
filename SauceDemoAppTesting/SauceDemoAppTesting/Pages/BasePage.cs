using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement FindElement(By locator)
        {
            return wait.Until(drv =>
            {
                var element = drv.FindElement(locator);
                return element.Displayed ? element : null;
            });
        }

        protected IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return driver.FindElements(locator);
        }

        protected void Click(By locator)
        {
            FindElement(locator).Click();
        }

        protected void Type(By locator, string text)
        {
            var element = FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By locator)
        {
            return FindElement(locator).Text;
        }
    }
}
