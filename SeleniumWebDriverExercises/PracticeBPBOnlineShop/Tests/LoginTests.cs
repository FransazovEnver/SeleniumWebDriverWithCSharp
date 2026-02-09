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

            var basePage = new LoginPage(driver);

            loginPage.buttonMyAccount.Click();

            loginPage.continueButton.Click();

            loginPage.gender.Click();

            loginPage.firstnameInput.SendKeys("test");

            loginPage.lastnameInput.SendKeys("test!");

            loginPage.dateOfBirth.SendKeys("10/10/2000");

            loginPage.emailAdress.SendKeys("test@test.bg");

            loginPage.companyName.SendKeys("IBM");

            loginPage.streetAddress.SendKeys("Sezam");

            loginPage.suburb.SendKeys("Mahalata");

            loginPage.postCode.SendKeys("4100");

            loginPage.city.SendKeys("Plovdiv");

            loginPage.stateProvince.SendKeys("Plovdiv");

            loginPage.country.SendKeys("Bulgaria");

            loginPage.telephoneNumber.SendKeys("0895123456");

            loginPage.faxNumber.SendKeys("0895123456");

            loginPage.newsLetter.Click();

            loginPage.password.SendKeys("Password");

            loginPage.comfirmPassword.SendKeys("Password");

            loginPage.submitButton.Click();

        }
    }
}
