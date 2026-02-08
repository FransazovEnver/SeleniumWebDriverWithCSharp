using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PracticeBPBOnlineShop.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By continueButton = By.XPath("//span[text()='Continue']");

        private readonly By buttonMyaccount = By.XPath("private readonly By");

        private readonly By gender = By.XPath("//input[@value='m']");

        private readonly By firstnameInput = By.XPath("//input[@name='firstname']");

        private readonly By lastnameInput = By.XPath("//input[@name='lastname']");

        private readonly By dateOfBirth = By.XPath("//input[@name='dob']");

        private readonly By emailAdress = By.XPath("//input[@name='email_address']");

        private readonly By companyName = By.XPath("//input[@name='company']");

        private readonly By streetAddress = By.XPath("//input[@name='street_address']");

        private readonly By suburb = By.XPath("//input[@name='suburb']");

        private readonly By postCode = By.XPath("//input[@name='postcode']");

        private readonly By city = By.XPath("//input[@name='city']");

        private readonly By stateProvince = By.XPath("//input[@name='state']");

        private readonly By country = By.XPath("//select[@name='country']");

        private readonly By telephoneNumber = By.XPath("//input[@name='telephone']");

        private readonly By faxNumber = By.XPath("//input[@name='fax']");

        private readonly By newsLetter = By.XPath("//input[@name='newsletter']");

        private readonly By password = By.XPath("//input[@name='password']");

        private readonly By comfirmPassword = By.XPath("//input[@name='confirmation']");

        private readonly By submitButton = By.XPath("//button[@type='submit']");
 
        public LoginPage(IWebDriver driver) : base(driver) 
        {

        }
    }
}
