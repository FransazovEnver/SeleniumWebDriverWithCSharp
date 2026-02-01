using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PracticeBPBOnlineShop
{
    public class BasePOMTests
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://practice.bpbonline.com/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

       
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}