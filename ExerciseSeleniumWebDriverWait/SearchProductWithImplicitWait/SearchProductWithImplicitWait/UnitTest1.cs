using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchProductWithImplicitWait
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

            var productName = driver.FindElement(By.XPath("(//a[text()='Microsoft Internet Keyboard PS/2'])[1]"));

            Assert.That(productName.Displayed, Is.True);

            driver.FindElement(By.XPath("//span[text()='Buy Now']")).Click();

            var cartPageTitle = driver.FindElement(By.TagName("h1"));

            Assert.That(cartPageTitle.Text, Is.EqualTo("What's In My Cart?"));

            var productNameInCart = driver.FindElement(By.XPath("(//table//td//a)[2]"));

            Assert.That(productNameInCart.Text, Is.EqualTo("Microsoft Internet Keyboard PS/2"));
        }

        [Test]
        public void SearchProduct_Junk_ThrowException()
        {
            driver.FindElement(By.XPath("//input[@name='keywords']")).SendKeys("junk");

            driver.FindElement(By.XPath("//input[@alt='Quick Find']")).Click();
            try
            {
                driver.FindElement(By.XPath("//span[text()='Buy Now']")).Click();

            }
            catch (NoSuchElementException ex)
            {
            }
            catch (StaleElementReferenceException stEx)
            {
            }

            Console.WriteLine("After try catch");

        }


        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver?.Quit();
                driver.Dispose();
            }
        }
    }
}
