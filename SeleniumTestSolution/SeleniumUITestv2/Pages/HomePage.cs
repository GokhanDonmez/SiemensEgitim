using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestv2.Pages
{
    public class HomePage
    {
        public static IWebDriver driver;

        public HomePage(IWebDriver driver) 
        { 
            HomePage.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }

        // Page Objects - For Webelements

        public static readonly By registerlink = By.ClassName("ico-register");
        public static readonly By loginlink = By.ClassName("ico-login");

        // Page Methods

        public void ClickRegisterLink()
        {
            driver.FindElement(registerlink).Click();
        }
    }
}
