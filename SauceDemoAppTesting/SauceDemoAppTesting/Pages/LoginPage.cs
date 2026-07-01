using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By usernameInput = By.XPath("//input[@name='user-name']");
        private readonly By userpasswordInput = By.XPath("//input[@name='password']");
        private readonly By loginButton = By.XPath("//input[@name='login-button']");
        private readonly By errorMassege = By.XPath("//h3[@data-test='error']");
        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }
    }
}
