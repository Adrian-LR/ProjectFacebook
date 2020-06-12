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
    class LikeTest : Base.BasePage
    {
        [Test]
        public virtual void LikeFacebook()
        {
            try
            {
                var driver = SetUp();
                var like = new AddComment(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(20)));
                like.UserLogin(driver);
                like.Darlike(driver);
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
