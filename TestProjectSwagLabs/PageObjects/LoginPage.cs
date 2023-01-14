using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Network;
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
        private readonly By submit = By.CssSelector("#login-button");



        private readonly string loginName= "standard_user";
        private readonly string passwordName = "secret_sauce";
        private readonly string loginName1 = "locked_out_user";


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public LoginPage SignIN()
        {
            driver.FindElement(login).SendKeys(loginName);
            driver.FindElement(password).SendKeys(passwordName);
            driver.FindElement(submit).Click();

            return this;

        }
        public LoginPage SignIN1()
        {
            driver.FindElement(login).SendKeys(loginName1);
            driver.FindElement(password).SendKeys(passwordName);
            driver.FindElement(submit).Click();

            return this;

        }
        public LoginPage ErrorMesage()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("h3[data-test='error']")).Displayed);
            return this;
        }

    }
}
