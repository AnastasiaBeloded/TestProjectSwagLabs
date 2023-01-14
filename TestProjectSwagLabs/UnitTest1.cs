using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectSwagLabs
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            
        }

        [TearDown]

        public  void TearDown()
        {
            //driver.Quit();
        }
 }

}