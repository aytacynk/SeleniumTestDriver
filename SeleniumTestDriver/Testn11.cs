using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestDriver
{
    [TestFixture]
    public class Testn11 : TestBase
    {
        [Test, Category("AddToFavoriteList Testing")]
        public void TestFavoriteList()
        {

            //Console.WriteLine("\t==> n11 Websitesi Kullanıcı Bilgilerinizi Giriniz\n");
            //Console.Write("Email adresiniz : ");
            //string email = Console.ReadLine();
            //Console.Write("Şifreiniz : ");
            //string password = Console.ReadLine();

            driver.Navigate().GoToUrl("https://www.n11.com/");
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("blokenstein@yandex.com");
            driver.FindElement(By.Id("password")).SendKeys("123456Z");
            driver.FindElement(By.Id("loginButton")).Click();

            driver.FindElement(By.Id("searchData")).SendKeys("samsung");
            driver.FindElement(By.ClassName("searchBtn")).Click();

            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();

            driver.FindElement(By.XPath(".//*[@id='p-209303029']/div[2]/span")).Click();

            driver.FindElement(By.ClassName("myAccount")).Click();

            driver.FindElement(By.XPath(".//*[@id='myAccount']/div/div/div[2]/ul/li[6]/a[1]")).Click();
            driver.FindElement(By.XPath(".//*[@id='myAccount']/div[3]/ul/li[1]/div/ul/li/a[1]")).Click();

            driver.FindElement(By.XPath(".//*[@id='p-209303029']/div[3]/span")).Click();

            Assert.AreEqual("Test is successfully", Program.createMessage());
        }

    }
}
