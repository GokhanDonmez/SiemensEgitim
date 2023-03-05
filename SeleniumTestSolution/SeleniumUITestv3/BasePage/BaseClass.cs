using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SeleniumUITestv2.BasePage
{
    /*
        Initialize the Driver - Setup Driver
        Re-usable Methods
     */
    public class BaseClass
    {
        public static IWebDriver driver;

        [TestInitialize]
        public void Init()
        {
            string siteurl = ConfigurationManager.AppSettings["url"];

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(siteurl);
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
