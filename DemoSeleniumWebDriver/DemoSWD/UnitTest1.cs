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

            //Print page title
            Console.WriteLine("Main page title: " + driver.Title);

            //Logate the search input
            var searchBox = driver.FindElement(By.Name("search"));

            //Write a text in seachBox and push the enter
            searchBox.SendKeys("Quality Assurance" + Keys.Enter);

            //Print the page title
            Console.WriteLine("Title after search: " + driver.Title);
            
            //close the browser
            driver.Quit();
        }
    }
}