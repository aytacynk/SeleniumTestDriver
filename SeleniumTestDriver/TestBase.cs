using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestDriver
{
    public class TestBase
    {

        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\AYTACH-PC\Desktop\chromedriver_win32");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
