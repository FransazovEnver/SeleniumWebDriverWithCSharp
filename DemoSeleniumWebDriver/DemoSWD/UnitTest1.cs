using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoSWD
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWikipediaUrl()
        {
            //Create chrome driver and open new chrome browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Url
            driver.Navigate().GoToUrl("https://wikipedia.org");

            //close the browser
            driver.Quit();
        }
    }
}