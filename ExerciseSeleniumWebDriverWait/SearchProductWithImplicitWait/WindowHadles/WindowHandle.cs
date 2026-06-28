using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace WindowHadles
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
        }

        [Test]
        public void HandleMutlipeWindows()
        {
            ReadOnlyCollection<string> windowHandleIdsBefore = driver.WindowHandles;
            
            driver.FindElement(By.XPath("//a[text()='Click Here']")).Click();

            ReadOnlyCollection<string> windowHandleIds = driver.WindowHandles;

            driver.SwitchTo().Window(windowHandleIds[1]);

            Assert.That(windowHandleIds.Count, Is.EqualTo(2));

            var newWindowTitle = driver.FindElement(By.TagName("h3"));

            Assert.That(newWindowTitle.Text, Is.EqualTo("New Window"));

            driver.SwitchTo().Window(windowHandleIds[0]);

        }
        [Test]
        public void NoSuchWindowInteraction()
        {
            driver.FindElement(By.XPath("//a[text()='Click Here']")).Click();

            ReadOnlyCollection<string> windowHandle = driver.WindowHandles;

            driver.SwitchTo().Window(windowHandle[1]);
            driver.Close();

            try
            {
                driver.SwitchTo().Window(windowHandle[1]);
            }
            catch (NoSuchWindowException ex)
            {
                Assert.Pass("Window was closed");
            }
            finally
            {
                driver.SwitchTo().Window(windowHandle[0]);
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
