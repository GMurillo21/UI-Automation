using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TecBeatsSample.Pages
{
    public class HomePage
    {

        private WebDriver driver;
        private WebDriverWait wait;

        public HomePage(WebDriver web_driver) {
            this.driver = web_driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement login;
        public bool isAt()
        {
            return driver.Title.Contains("Swag Labs");
        }
        public void SendUsername(string name) //standard_user
        {
            username.SendKeys(name);
        }
        public void SendPassword(string email) //secret_sauce
        {
            password.SendKeys(email);
        }
        public void clickSubmit()
        {
            login.Submit();
        }

        public Inventory LoginUser(string user, string pass)
        {
            SendUsername(user);
            SendPassword(pass);
            clickSubmit();
            return new Inventory(driver);
        }
    }
}
