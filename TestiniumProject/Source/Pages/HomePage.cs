using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestiniumProject.Source.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement _searchtxtbox;
 
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Search(string searchtext)
        {
            _searchtxtbox.SendKeys(searchtext);
        }
    }
}
