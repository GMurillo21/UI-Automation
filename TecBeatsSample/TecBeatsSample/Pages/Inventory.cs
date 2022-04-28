using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class Inventory
    {

        private WebDriver driver;
        private WebDriverWait wait;

        public Inventory(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        private IWebElement addBackpack;
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        private IWebElement addBikeLight;
        [FindsBy(How = How.XPath, Using = "//*[@id='shopping_cart_container']/a")]
        private IWebElement cartBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement label;

        public bool isLabelCorrect()
        {
            return label.Text.ToUpper() == "PRODUCTS";
        }
        public void AddSauceLabsBackpack() 
        {
            addBackpack.Click();
        }
        public void AddSauceLabsBikeLight()
        {
            addBikeLight.Click();
        }
        public void OpenCart()
        {
            cartBtn.Click();
        }

        public Cart AddItemsAndOpenCart()
        {
            AddSauceLabsBackpack();
            AddSauceLabsBikeLight();
            OpenCart();
            return new Cart(driver);
        }
    }
}
