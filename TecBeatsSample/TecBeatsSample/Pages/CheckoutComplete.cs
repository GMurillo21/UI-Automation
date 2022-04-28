using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class CheckoutComplete
    {

        private WebDriver driver;
        private WebDriverWait wait;

        public CheckoutComplete(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement label;

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout_complete_container']/h2")]
        private IWebElement labelConfirmation;

        public bool isLabelCorrect()
        {            
            return label.Text.ToUpper() == "CHECKOUT: COMPLETE!" && labelConfirmation.Text.ToUpper() == "THANK YOU FOR YOUR ORDER";
        }

    }
}
