using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoAppTesting.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By usernameInput = By.XPath("//input[@name='user-name']");
        private readonly By passwordInput = By.XPath("//input[@name='password']");
        private readonly By loginButton = By.XPath("//input[@name='login-button']");
        private readonly By errorMassege = By.XPath("//h3[@data-test='error']");
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public void TypeUserName(string username)
        {
            Type(usernameInput, username);
        }

        public void TypePassword(string password)
        {
            Type(passwordInput, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
            return GetText(errorMassege);
        }
    }
}
