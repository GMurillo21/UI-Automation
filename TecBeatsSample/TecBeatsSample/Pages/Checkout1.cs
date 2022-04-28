using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class Checkout1
    {

        private WebDriver driver;
        private WebDriverWait wait;

        public Checkout1(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement txtFirst;
        [FindsBy(How = How.Id, Using = "last-name")]
        private IWebElement txtLast;
        [FindsBy(How = How.Id, Using = "postal-code")]
        private IWebElement postalCode;
        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement label;

        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement btnContinue;

        [FindsBy(How = How.Id, Using = "cancel")]
        private IWebElement btnCancel;

        public bool isLabelCorrect()
        {
            return label.Text.ToUpper() == "CHECKOUT: YOUR INFORMATION";
        }

        public Checkout2 EnterDataAndContinue(string name, string last, string zip)
        {
            txtFirst.SendKeys(name);
            txtLast.SendKeys(last);
            postalCode.SendKeys(zip);
            btnContinue.Click();
            return new Checkout2(driver);
        }
    }
}
