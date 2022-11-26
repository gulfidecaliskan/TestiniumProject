using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace TestiniumProject.Source.Pages
{
    public class Cart
    {
        private IWebDriver driver;
        private IWebElement continueButton;
        public Cart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public static void AddToCart(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.network.com.tr/cart");

            WebElement continueButton = (WebElement)driver.FindElement(By.ClassName("continueButton n-button large block text-center primary"));
            //continueButton.Click();
        }
    }
}
