using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using ProjectFacebook.Locators;
using System.Threading;



namespace ProjectFacebook.Automation
{
    class AddComment
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;
        
        LoginLocators loginLoc;
        HomeLocators  homeLoc;


        public AddComment(RemoteWebDriver Driver, WebDriverWait Wait)
        {
           driver = Driver;
           wait = Wait;
        }
		
		private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

		public void UserLogin(RemoteWebDriver driver)
        {
            loginLoc = new LoginLocators(driver, wait);

          if (IsElementPresent(loginLoc.UserBox))
            {
                driver.FindElement(loginLoc.UserBox).Click();
                driver.FindElement(loginLoc.UserBox).SendKeys("XXXXXXXX");
                driver.FindElement(loginLoc.PwdBox).Click();
                driver.FindElement(loginLoc.PwdBox).SendKeys("XXXXXXXX");
                driver.FindElement(loginLoc.LoginButton).Click();
            }
            else if(IsElementPresent(loginLoc.UserBox2))
            {
                driver.FindElement(loginLoc.UserBox2).Click();
                driver.FindElement(loginLoc.UserBox2).SendKeys("XXXXXXXXX");
                driver.FindElement(loginLoc.PwdBox2).Click();
                driver.FindElement(loginLoc.PwdBox2).SendKeys("XXXXXXXXXXX");
                driver.FindElement(loginLoc.LoginButton).Click();
            }
        }

        public void mandarMensaje(RemoteWebDriver driver)
        {           
            try
            {
                homeLoc = new HomeLocators(driver, wait);
                Thread.Sleep(5000);
                homeLoc.btnbuscarChat.Click();
                Thread.Sleep(5000);
                homeLoc.txtBuscarChat.Click();
                Thread.Sleep(2000);
                homeLoc.txtBuscarChat.SendKeys("Oscar Cova");
                Thread.Sleep(5000);
                homeLoc.seleccionaCova.Click();
                Thread.Sleep(2000);
                homeLoc.txtMensajeCova.SendKeys("Hola");
                Thread.Sleep(2000);
                homeLoc.btnEnviarACova.Click();               
                
            }
            catch (Exception e)
            {                
                
            }
        }

    }
}
