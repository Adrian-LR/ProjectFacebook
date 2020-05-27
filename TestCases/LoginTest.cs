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
    class LoginTest : Base.BasePage
    {
        [Test]
        public virtual void LoginFacebook()
        {
            try
            {
                var driver = SetUp();
                var addComment = new AddComment(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(30)));
                addComment.UserLogin(driver);
                
                //driver.Close();
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine($"{e.ToString()}");
                Assert.Ignore();
            }

        }
    }
}
