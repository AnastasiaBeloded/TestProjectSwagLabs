using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProjectSwagLabs.PageObjects;


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
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            

            

        }

        [Test]
        public void TestLogin()
        {
            var login = new LoginPage(driver)
                .SignIN();
            var burgerMenu = new ProductsPage(driver)
                .burgerMenu();
           
        }
        [Test]
        public void TestLogin1()
        {
            var login = new LoginPage(driver)
                .SignIN1()
                .ErrorMesage();
            

        }

        [TearDown]

        public  void TearDown()
        {
            //driver.Quit();
        }
 }

}