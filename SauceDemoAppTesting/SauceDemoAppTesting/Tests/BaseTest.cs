using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDemoAppTesting.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        
        [SetUp]
        public void SetUp() 
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            driver = new ChromeDriver(chromeOptions);

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        protected void PerformLogin(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);

            loginPage.TypeUserName(username);
            loginPage.TypePassword(password);
            loginPage.ClickLoginButton();
        }
    }
}
