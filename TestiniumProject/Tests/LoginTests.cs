using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiniumProject.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestiniumProject.Tests
{
    public class LoginTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }

#pragma warning disable NUnit1027 // The test method has parameters, but no arguments are supplied by attributes
        [Test]
#pragma warning restore NUnit1027 // The test method has parameters, but no arguments are supplied by attributes
        public void Login(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.network.com.tr/customer/login?returnUrl=%2Fcheckout&isGuestCheckOut=True#delivery");

            String[] csvLines = System.IO.File.ReadAllLines("people.csv");

            var mails = new List<string>();
            var passwords = new List<string>();

            for (int i = 0; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                mails.Add(rowData[0]);
                passwords.Add(rowData[1]);
            }

            String userMail = mails[0];
            String userPass = passwords[0];

            WebElement enterMail = (WebElement)driver.FindElement(By.XPath("//*[@id='login']/div[1]/div/label"));
            enterMail.Click();
            //enterMail.SendKeys(userMail);

            WebElement enterPass = (WebElement)driver.FindElement(By.XPath("//*[@id='login']/div[2]/div/label"));
            enterPass.Click();
            //enterPass.SendKeys(userPass);
        }
        public static void ClickNetwork(IWebElement driver)
        {
            WebElement networkLogo = (WebElement)driver.FindElement(By.ClassName("header__logoImg"));
            networkLogo.Click();
        }

        public static void ClickBagLogo(IWebElement driver)
        {
            WebElement bagLogo = (WebElement)driver.FindElement(By.ClassName("header__icon -shoppingBag"));
            bagLogo.Click();
        }
        public static void RemoveProduct(IWebElement driver)
        {
            WebElement removeProduct = (WebElement)driver.FindElement(By.XPath("//*[@id='header__desktopBasket']/div/div[2]/div/div[3]/svg/use"));
            removeProduct.Click();
        }
        public static void RemoveButton(IWebElement driver)
        {
            WebElement removeButton = (WebElement)driver.FindElement(By.ClassName("btn -black o-removeCartModal__button"));
            removeButton.Click();
        }


        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }

    }
}
