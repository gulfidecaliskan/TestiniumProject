using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
    public class ProductListTests
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
        public void scrollDownThePage(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.network.com.tr/search?searchKey=ceket");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,11916.4)");

        }
        public void ClickShowMore(IWebDriver driver)
        {
            IWebElement showMoreButton = driver.FindElement(By.ClassName("button -secondary -sm relative"));
            //showMoreButton.Click();
            String secondPageUrl = driver.Url;
        }

        public void MouseHoverProduct(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.network.com.tr/search?searchKey=ceket&page=2");
            WebElement product = (WebElement)driver.FindElement(By.XPath("//*[@id='products']/div[3]/div/div[1]/div/div[1]/a[2]/div/div[3]"));
            Actions action = new Actions(driver);
            action.MoveToElement(product).Perform();
            WebElement productSize = (WebElement)driver.FindElement(By.XPath("//*[@id='products']/div[3]/div/div[1]/div/div[1]/div/div/div/div[1]/label"));
            //productSize.Click();
        }
        public void GoToCart(IWebDriver driver)
        {
            WebElement goToCart = (WebElement)driver.FindElement(By.ClassName("button -primary header__basket--checkout header__Basketmodal -checkout"));
            //goToCart.Click();
            String cartUrl = driver.Url;
        }


        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
