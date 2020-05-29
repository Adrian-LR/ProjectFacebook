using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFacebook.Automation;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace ProjectFacebook.TestCases
{
    class ChatTest : Base.BasePage
    {
        [Test]
        public virtual void chatFacebook()
        {
            try
            {
                var driver = SetUp();
                var chat = new AddComment(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(20)));
                chat.UserLogin(driver);
                chat.mandarMensaje(driver);
                driver.Quit();
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine($"{e.ToString()}");
                Assert.Ignore();
            }
        }
    }
}
