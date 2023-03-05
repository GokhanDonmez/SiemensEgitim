using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumUITest
{
    [TestClass]
    public class SampleTest
    {
        string email = "cihan1@email.com";
        IWebDriver driver;

        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }

        [TestCategory("SampleTest")]
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click();
                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.Id("FirstName")).SendKeys("Cihan");
                driver.FindElement(By.Id("LastName")).SendKeys("Ozhan");
                driver.FindElement(By.Id("Email")).SendKeys(email);
                driver.FindElement(By.Id("Password")).SendKeys("excalibur47");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("excalibur47");
                driver.FindElement(By.Id("register-button")).Click();

                // Get the success message
                string message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                IWebElement emailElement = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailElement.Displayed);

                // Logout
                driver.FindElement(By.ClassName("ico-logout")).Click();

                //driver.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
