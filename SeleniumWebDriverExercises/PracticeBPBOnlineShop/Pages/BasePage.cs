using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PracticeBPBOnlineShop
{
    public class BasePage
    {
        protected IWebDriver driver; 

        protected WebDriverWait wait;

        //This is a constructor with driver, explicit wait and main Url
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;   
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://practice.bpbonline.com/");
        }

        //Method who wait for element to be visible
        protected IWebElement FindElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        //Clicking element method 
        protected void Click(By locator)
        {
            FindElement(locator).Click();
        }

        //Typing method
        protected void Type(By locator, string text)
        {
            var element = FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }
    }
}