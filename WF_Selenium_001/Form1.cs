using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WF_Selenium_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRun.Click += BtnRun_Click;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            //https://www.google.com/search?q=cihanozhan
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var searchBox = driver.FindElement(By.Name("q"));
            if (searchBox!=null)
            {
                searchBox.SendKeys("Cihan Özhan");
                searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            driver.Quit();
        }
    }
}
