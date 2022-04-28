using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class Cart
    {

        private WebDriver driver;
        private WebDriverWait wait;
        Int32 timeout = 10000; // in milliseconds

        public Cart(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout']")]
        private IWebElement btnCheckout;

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement label;

        public void load_complete(int timeout)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));

            // Wait for the page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public bool isLabelCorrect()
        {
            return label.Text.ToUpper() == "YOUR CART";
        }

        public void Checkout()
        {
            load_complete(timeout);
            btnCheckout.Click();
        }

        public Checkout1 GoToCheckout()
        {
            Checkout();
            return new Checkout1(driver);
        }
    }
}
