using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace TestiniumProject.Source.Pages
{
    public class ProductList
    {
        private IWebDriver driver;
        private IWebElement showMoreButton;
        //private IWebElement product;
        private IWebElement productSize;
        private IWebElement goToCart;

        public ProductList(IWebDriver driver)
        {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
        }
        public void ClickShowMoreButton()
        {
            showMoreButton.Click();
        }
        public void ChooseProductSize()
        {
            productSize.Click();
        }
        public void ClickCartButton()
        {
            goToCart.Click();
        }

    }
}

