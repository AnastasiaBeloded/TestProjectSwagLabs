using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectSwagLabs.PageObjects
{
    internal class ProductsPage
    {
        private IWebDriver driver;
        

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public ProductsPage burgerMenu()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#react-burger-menu-btn")).Displayed);
            return 
               new ProductsPage(driver);
        }

    }

}
