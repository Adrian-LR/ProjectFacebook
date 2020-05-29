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
    class HomeLocators
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;

        public HomeLocators(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }
        public IWebElement btnbuscarChat => driver.FindElementByXPath("//*[@class=\"ozuftl9m tvfksri0\"]/div");
        public IWebElement txtBuscarChat => driver.FindElementByCssSelector("[class = \"oajrlxb2 rq0escxv f1sip0of hidtqoto lzcic4wl ijkhr0an nlq1og4t sgqwj88q g5ia77u1 oo9gr5id b1f16np4 hdh3q7d8 dwo3fsh8 qu0x051f esr5mh6w e9989ue4 r7d6kgcz br7hx15l h2jyy9rg n3ddgdk9 owxd89k7 ihxqhq3m jq4qci2q k4urcfbm iu8raji3 tv7at329 l60d2q6s d1544ag0 hwnh5xvq tw6a2znq aj8hi1zk r4fl40cc kd8v7px7 m07ooulj mzan44vs\"]");
        public IWebElement seleccionaCova => driver.FindElementByXPath("//*[@id=\"768966613\"]/div/div[1]/div");
        public IWebElement txtMensajeCova => driver.FindElementByCssSelector("[class=\"_1mf _1mj\"]");
        public IWebElement btnEnviarACova => driver.FindElementByCssSelector("[d = \"M16.6915026, 12.4744748 L3.50612381, 13.2599618 C3.19218622, 13.2599618 3.03521743, 13.4170592 3.03521743, 13.5741566 L1.15159189, 20.0151496 C0.8376543, 20.8006365 0.99, 21.89 1.77946707, 22.52 C2.41, 22.99 3.50612381, 23.1 4.13399899, 22.8429026 L21.714504, 14.0454487 C22.6563168, 13.5741566 23.1272231, 12.6315722 22.9702544, 11.6889879 C22.8132856, 11.0605983 22.3423792, 10.4322088 21.714504, 10.118014 L4.13399899, 1.16346272 C3.34915502, 0.9 2.40734225, 1.00636533 1.77946707, 1.4776575 C0.994623095, 2.10604706 0.8376543, 3.0486314 1.15159189, 3.99121575 L3.03521743, 10.4322088 C3.03521743, 10.5893061 3.34915502, 10.7464035 3.50612381, 10.7464035 L16.6915026, 11.5318905 C16.6915026, 11.5318905 17.1624089, 11.5318905 17.1624089, 12.0031827 C17.1624089, 12.4744748 16.6915026, 12.4744748 16.6915026, 12.4744748 Z\"]");
     }
}
