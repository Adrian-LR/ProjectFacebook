sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Virtualpiano.Locators
{
    class FolowLocators
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;

        public FolowLocators(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }
         pubic IWebElement TextBuscar => driver.FindElement(By.XPath("//input[contains(@name,'q')]"));
         public IWebElement LinkCova => driver.FindElement(By.XPath("//a[contains(text(),'Cova LoL')] "));
         public IWebElement DaleLike => driver.FindElement(By.XPath("//button[contains(text(),'Me gusta')]"));
         public IWebElement SeleccionaCmt => driver.FindElement(By.XPath("/html[1]/body[1]/div[13]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]"));
    }
}
