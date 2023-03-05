using OpenQA.Selenium;
using SeleniumUITestv3.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestv3.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            LoginPage.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }

        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginbtn = By.CssSelector("input.button-1.login-button");

        // Page Methods

        public void EnterEmailAddress(string email)
        {
            driver.EnterText(emailtxt, email);
        }

        public void EnterPassword(string password)
        {
            driver.EnterText(passwordtxt, password);
        }

        public void ClickLoginButton()
        {
            driver.Click(loginbtn);
        }
    }
}
