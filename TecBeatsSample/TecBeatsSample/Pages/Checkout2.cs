using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class Checkout2
    {

        private WebDriver driver;
        private WebDriverWait wait;

        public Checkout2(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement label;

        [FindsBy(How = How.Id, Using = "finish")]
        private IWebElement btnFinish;

        [FindsBy(How = How.Id, Using = "cancel")]
        private IWebElement btnCancel;

        public bool isLabelCorrect()
        {
            return label.Text.ToUpper() == "CHECKOUT: OVERVIEW";
        }

        public CheckoutComplete FinishOrder()
        {
            btnFinish.Click();
            return new CheckoutComplete(driver);
        }
    }
}
