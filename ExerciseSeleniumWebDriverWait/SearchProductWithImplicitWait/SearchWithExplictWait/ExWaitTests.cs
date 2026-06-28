using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Timers;

namespace SearchWithExplictWait
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://practice.bpbonline.com/");
        }

        [Test]
        public void SearchForKeyboard()
        {
            driver.FindElement(By.XPath("//input[@name='keywords']")).SendKeys("keyboard");

            driver.FindElement(By.XPath("//input[@alt='Quick Find']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var productName = wait.Until(drv => drv.FindElement(By.XPath("(//a[text()='Microsoft Internet Keyboard PS/2'])[1]")));

            Assert.That(productName.Text, Is.EqualTo("Microsoft Internet Keyboard PS/2"));

            var buyButton = wait.Until(drv => drv.FindElement(By.XPath("//span[text()='Buy Now']")));
            buyButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            var cartPageTitle = driver.FindElement(By.TagName("h1"));
            Assert.That(cartPageTitle.Text, Is.EqualTo("What's In My Cart?"));

            var cartPageProduct = driver.FindElement(By.XPath("(//a[text()='Microsoft Internet Keyboard PS/2'])[1]"));

            Assert.That(cartPageProduct.Text, Is.EqualTo("Microsoft Internet Keyboard PS/2"));
        }

        [Test]
        public void Search_With_NonExistingProductName()
        {
            driver.FindElement(By.XPath("//input[@name='keywords']")).SendKeys("junk");

            driver.FindElement(By.XPath("//input[@alt='Quick Find']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                var buyNowButton = wait.Until(drv => drv.FindElement(By.XPath("//span[text()='Buy Now']")));
                buyNowButton.Click();
                Assert.Fail("Buy Button was present on the page");
            }
            catch (WebDriverTimeoutException ex)
            {
                Assert.Pass("Buy now button was not present in the page");
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        }

        [TearDown]
        public void teardown()
        {
                driver.Quit();
                driver.Dispose();
            
        }
    }
}
