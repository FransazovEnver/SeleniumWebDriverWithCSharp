using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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

        [TearDown]
        public void teardown()
        {
            if (driver != null)
            {
                driver?.Quit();
                driver.Dispose();
            }
        }
    }
}
