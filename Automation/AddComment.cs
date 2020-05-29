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

        public void UserLogin(RemoteWebDriver driver)
        {
            loginLoc = new LoginLocators(driver, wait);

            loginLoc.UserBox.Click();
            loginLoc.UserBox.SendKeys("xxxxxx@hotmail.com");
            loginLoc.PwdBox.Click();
            loginLoc.PwdBox.SendKeys("xxxxxxx");
            loginLoc.LoginButton.Click();
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
