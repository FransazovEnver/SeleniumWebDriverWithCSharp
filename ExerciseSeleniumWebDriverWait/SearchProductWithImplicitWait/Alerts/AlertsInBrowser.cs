using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alerts
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
        }

        [Test]
        public void HandleBasicAlert()
        {
            driver.FindElement(By.XPath("//button[text()='Click for JS Alert']")).Click();

            IAlert alert = driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("I am a JS Alert"));

            alert.Accept();

            var result = driver.FindElement(By.XPath("//p[@id='result']"));

            Assert.That(result.Text, Is.EqualTo("You successfully clicked an alert"));
        }

        [Test]

        public void HandleComfirmAlert()
        {
            driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']")).Click();
            IAlert alert = driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("I am a JS Confirm"));

            alert.Accept();

            var result = driver.FindElement(By.XPath("//p[@id='result']"));

            Assert.That(result.Text, Is.EqualTo("You clicked: Ok"));

            driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']")).Click();
            
            IAlert newAlert = driver.SwitchTo().Alert();

            newAlert.Dismiss();

            Assert.That(result.Text, Is.EqualTo("You clicked: Cancel"));
        }

        [Test]
        public void HandlePromptAlert()
        {
            driver.FindElement(By.XPath("//button[@onclick='jsPrompt()']")).Click();
            IAlert alert = driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("I am a JS prompt"));

            string inputValue = "Hello";

            alert.SendKeys(inputValue);
            alert.Accept();

            var resultElement = driver.FindElement(By.XPath("//p[@id='result']"));

            Assert.That(resultElement.Text, Is.EqualTo($"You entered: {inputValue}"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
