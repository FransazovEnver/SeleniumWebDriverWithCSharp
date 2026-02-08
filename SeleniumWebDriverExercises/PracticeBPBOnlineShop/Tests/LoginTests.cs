using OpenQA.Selenium;
using PracticeBPBOnlineShop.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBPBOnlineShop.Tests
{
    public class LoginTests : BaseTests

    {
        [Test]
        public void Test_RegisterUser()
        {
            var loginPage = new LoginPage(driver);

            loginPage.buttonMyAccount.Click();

            loginPage.continueButton.Click();

            loginPage.gender.Click();

            loginPage.lastnameInput.Click();

            loginPage.dateOfBirth.SendKeys("02/05/2000");

            loginPage.emailAdress.Click();

            loginPage.companyName.Click();

            loginPage.streetAddress.Click();

            loginPage.suburb.Click();

            loginPage.postCode.Click();

            loginPage.city.Click();

            loginPage.stateProvince.Click();

            loginPage.country.Click();

            loginPage.telephoneNumber.Click();

            loginPage.faxNumber.Click();

            loginPage.newsLetter.Click();

            loginPage.password.Click();

            loginPage.comfirmPassword.Click();

            loginPage.submitButton.Click();

        }
    }
}
