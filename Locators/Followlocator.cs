sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace ProjectFacebook.Locators
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
        public By TextBuscar => By.XPath("//input[contains(@name,'q')]");
        public By LinkCova => By.XPath("//a[contains(text(),'Cova LoL')]");
        public By DaleLike => By.XPath("//button[contains(text(),'Me gusta')]");
        public By SeleccionaCmt => By.XPath("/html[1]/body[1]/div[13]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]");

        public By TextBuscar2 => By.XPath("//input[contains(@name,'q')]");
        public By LinkCova2 => By.XPath("//a[contains(text(),'Cova LoL')]");
        public By DaleLike2 => By.XPath("//button[contains(text(),'Me gusta')]");
        public By SeleccionaCmt2 => By.XPath("/html[1]/body[1]/div[13]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]");

    }
}
