using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectSwagLabs.PageObjects
{
    internal class LoginPage
    {
        private IWebDriver driver;

        private readonly By login = By.CssSelector("#user-name");
        private readonly By password = By.CssSelector("#password");


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
