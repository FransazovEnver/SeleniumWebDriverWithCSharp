using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PracticeBPBOnlineShop.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement buttonMyAccount => driver.FindElement(By.XPath("//span[text()='My Account']"));

        public IWebElement continueButton => driver.FindElement(By.XPath("//span[text()='Continue']"));

        public IWebElement gender => driver.FindElement(By.XPath("//input[@value='m']"));

        public IWebElement firstnameInput => driver.FindElement(By.XPath("//input[@name='firstname']"));

        public IWebElement lastnameInput => driver.FindElement(By.XPath("//input[@name='lastname']"));

        public IWebElement dateOfBirth => driver.FindElement(By.XPath("//input[@name='dob']"));

        public IWebElement emailAdress => driver.FindElement(By.XPath("//input[@name='email_address']"));

        public IWebElement companyName => driver.FindElement(By.XPath("//input[@name='company']"));

        public IWebElement streetAddress => driver.FindElement(By.XPath("//input[@name='street_address']"));

        public IWebElement suburb => driver.FindElement(By.XPath("//input[@name='suburb']"));

        public IWebElement postCode => driver.FindElement(By.XPath("//input[@name='postcode']"));

        public IWebElement city => driver.FindElement(By.XPath("//input[@name='city']"));

        public IWebElement stateProvince => driver.FindElement(By.XPath("//input[@name='state']"));

        public IWebElement country => driver.FindElement(By.XPath("//select[@name='country']"));

        public IWebElement telephoneNumber => driver.FindElement(By.XPath("//input[@name='telephone']"));

        public IWebElement faxNumber => driver.FindElement(By.XPath("//input[@name='fax']"));

        public IWebElement newsLetter => driver.FindElement(By.XPath("//input[@name='newsletter']"));

        public IWebElement password => driver.FindElement(By.XPath("//input[@name='password']"));

        public IWebElement comfirmPassword => driver.FindElement(By.XPath("//input[@name='confirmation']"));

        public IWebElement submitButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        

    }
}
