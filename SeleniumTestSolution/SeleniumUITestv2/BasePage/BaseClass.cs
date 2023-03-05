using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
