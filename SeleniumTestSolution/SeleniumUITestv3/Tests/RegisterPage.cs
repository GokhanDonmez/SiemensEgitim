using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITestv2.BasePage;
using SeleniumUITestv2.Pages;
using System;

namespace SeleniumUITestv2.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {
        public HomePage homePage;
        public RegisterPage registerPage;
        string email = "cihan02@email.com";

        [TestMethod]
        public void VerifyRegisterFunctionalityWithValidData()
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadioButton();
            registerPage.EnterFirstName("Cihan");
            registerPage.EnterLastName("Oz");
            registerPage.EnterEmail(email);
            registerPage.EnterPassword("this-is-pwd!");
            registerPage.EnterConfirmPassword("this-is-pwd!");
            registerPage.ClickRegisterButton();
            string result = registerPage.GetSuccessMessage();
            Assert.AreEqual(result, "Your registration completed!");
            bool isTrue = registerPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(isTrue);
            registerPage.ClickLogoutButton();
        }
    }
}
