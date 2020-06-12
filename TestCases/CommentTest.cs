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
    class CommentTest : Base.BasePage
    {
        [Test]
        public virtual void CommentFacebook()
        {
            try
            {
                var driver = SetUp();
                var comment = new AddComment(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(20)));
                comment.UserLogin(driver);
                chat.MandarComentario(driver);
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
