using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using ProjectFacebook.Locators;


namespace ProjectFacebook.Automation
{
    class AddComment
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;
        
        LoginLocators loginLoc;


        public AddComment(RemoteWebDriver Driver, WebDriverWait Wait)
        {
           driver = Driver;
           wait = Wait;
        }

        public void UserLogin(RemoteWebDriver driver)
        {
            loginLoc = new LoginLocators(driver, wait);

            loginLoc.UserBox.Click();
            loginLoc.UserBox.SendKeys("xxxxxx@hotmail.com");
            loginLoc.PwdBox.Click();
            loginLoc.PwdBox.SendKeys("xxxxxxx");
            loginLoc.LoginButton.Click();
        }

    }
}
