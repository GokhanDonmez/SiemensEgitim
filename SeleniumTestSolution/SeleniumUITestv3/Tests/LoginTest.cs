using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITestv2.BasePage;
using SeleniumUITestv2.Pages;
using SeleniumUITestv3.Pages;
using System.Configuration;

namespace SeleniumUITestv2.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homePage;
        LoginPage loginPage;

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];

            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();
        }
    }
}
