using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiniumProject.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestiniumProject.Tests
{
    public class HomeTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            SearchBook();
        }


        [Test]
        public void SearchBook()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://www.network.com.tr/");
            String currentUrl = _driver.Url;
            hp.Search("ceket");
            Assert.True(_driver.Title.Contains("ceket"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
