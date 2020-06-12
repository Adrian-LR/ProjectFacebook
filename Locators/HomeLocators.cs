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

        //Versión nueva fb
        public By btnbuscarChat = By.XPath("//*[@class=\"ozuftl9m tvfksri0\"]/div");
        public By txtBuscarChat = By.CssSelector("[class = \"oajrlxb2 rq0escxv f1sip0of hidtqoto lzcic4wl ijkhr0an nlq1og4t sgqwj88q g5ia77u1 oo9gr5id b1f16np4 hdh3q7d8 dwo3fsh8 qu0x051f esr5mh6w e9989ue4 r7d6kgcz br7hx15l h2jyy9rg n3ddgdk9 owxd89k7 ihxqhq3m jq4qci2q k4urcfbm iu8raji3 tv7at329 l60d2q6s d1544ag0 hwnh5xvq tw6a2znq aj8hi1zk r4fl40cc kd8v7px7 m07ooulj mzan44vs\"]");
        public By seleccionaCova = By.XPath("//*[@id=\"768966613\"]/div/div[1]/div");
        public By txtMensajeCova = By.CssSelector("#mount_0_0 > div > div > div.rq0escxv.l9j0dhe7.du4w35lb > div.poy2od1o.i09qtzwb.n7fi1qx3 > div.l9j0dhe7.fh5enmmv > div.l9j0dhe7.tkr6xdv7 > div.j83agx80.l9j0dhe7.du4w35lb.aovydwv3.do00u71z > div > div > div > div > div > div > div.rj1gh0hx.buofh1pr.l9j0dhe7.du4w35lb > div > div.pfnyh3mw > form > div > div.j83agx80.l9j0dhe7.aovydwv3.ni8dbmo4.stjgntxs.nred35xi.n8tt0mok.hyh9befq > div.aovydwv3.j83agx80.buofh1pr.ni8dbmo4.cxgpxx05.sj5x9vvc.qio8uep8.l9j0dhe7 > div.orhb3f3m.h905i5nu.jinzq4gt.emzo65vh.dflh9lhu.e5nlhep0.ecm0bbzt.h4z51re5.gvyehdmr.mu0vl6fp.msuhji6j.iqy7zqfr.rj1gh0hx.cbu4d94t.buofh1pr.j83agx80.ni8dbmo4.ll8tlv6m.b3i9ofy5.oo9gr5id.flx89l3n.dpja2al7.hedjyaoh > div > div > div > div > div._5rpb > div > div > div > div");
        public By btnEnviarACova = By.CssSelector("[d = \"M16.6915026, 12.4744748 L3.50612381, 13.2599618 C3.19218622, 13.2599618 3.03521743, 13.4170592 3.03521743, 13.5741566 L1.15159189, 20.0151496 C0.8376543, 20.8006365 0.99, 21.89 1.77946707, 22.52 C2.41, 22.99 3.50612381, 23.1 4.13399899, 22.8429026 L21.714504, 14.0454487 C22.6563168, 13.5741566 23.1272231, 12.6315722 22.9702544, 11.6889879 C22.8132856, 11.0605983 22.3423792, 10.4322088 21.714504, 10.118014 L4.13399899, 1.16346272 C3.34915502, 0.9 2.40734225, 1.00636533 1.77946707, 1.4776575 C0.994623095, 2.10604706 0.8376543, 3.0486314 1.15159189, 3.99121575 L3.03521743, 10.4322088 C3.03521743, 10.5893061 3.34915502, 10.7464035 3.50612381, 10.7464035 L16.6915026, 11.5318905 C16.6915026, 11.5318905 17.1624089, 11.5318905 17.1624089, 12.0031827 C17.1624089, 12.4744748 16.6915026, 12.4744748 16.6915026, 12.4744748 Z\"]");

        //´Versión vieja fb
        public By btnbuscarChat1 = By.CssSelector("#chatsearch > div._1nq2 > span > label > input");
        public By txtBuscarChat1 = By.CssSelector("#chatsearch > div._1nq2 > span > label > input");
        public By seleccionaCova1 = By.XPath("//*[@id=\"chatsearch\"]/div[1]/span/div/div/div[1]");
        public By txtMensajeCova1 = By.CssSelector("[class=\"_1mf _1mj\"]");
        public By btnEnviarACova1 = By.CssSelector("#js_xe > svg");
    }
}
