using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
namespace TestiniumProject.Tests
{

    public class CartTests
    {
        private IWebDriver _driver;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private IWebElement continueButton;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }
#pragma warning disable NUnit1027 // The test method has parameters, but no arguments are supplied by attributes
        [Test]
#pragma warning restore NUnit1027 // The test method has parameters, but no arguments are supplied by attributes
        public void ClicktoAddCart(IWebDriver driver)
        {
            continueButton.Click();
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
