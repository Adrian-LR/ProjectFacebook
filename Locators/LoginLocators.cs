using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace ProjectFacebook.Locators
{
    class LoginLocators
    {

        private RemoteWebDriver driver;
        private WebDriverWait wait;

        public LoginLocators(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }
        public IWebElement UserBox => driver.FindElementByCssSelector("#email");
        public IWebElement PwdBox => driver.FindElementByCssSelector("#pass");
        public IWebElement LoginButton => driver.FindElementByCssSelector("#loginbutton");

    }
}
