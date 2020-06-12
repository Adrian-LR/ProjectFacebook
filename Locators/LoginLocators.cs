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
        public By UserBox = By.CssSelector("#email");
        public By UserBox2 = By.CssSelector(".inputtext.login_form_input_box#email");
        public By PwdBox = By.CssSelector("#pass");
        public By PwdBox2 = By.CssSelector(".inputtext.login_form_input_box#pass");
        public By LoginButton = By.CssSelector("#loginbutton");

    }
}
