using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using SeleniumExtras.PageObjects;

namespace TestiniumProject.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private IWebElement enterMail;
        private IWebElement enterPass;
        /*
        private IWebElement networkLogo;
        private IWebElement bagLogo;
        private IWebElement removeProduct;
        private IWebElement removeButton;
        */
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void sendMail(String userMail)
        {
            enterMail.SendKeys(userMail);
        }
        public void sendPass(String userPass)
        {
            enterPass.SendKeys(userPass);
        }   

    }
 }
