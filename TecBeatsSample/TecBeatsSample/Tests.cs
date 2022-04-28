using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TecBeatsSample.Pages;

namespace TecBeatsSample
{
    public class Tests
    {
        ChromeDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("../../../drivers/");

            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void Checkout()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            string username = "standard_user";
            string password = "secret_sauce";
            HomePage home_page = new HomePage(driver);

            //Verify user is logged in properly
            Inventory inv = home_page.LoginUser(username, password);
            Assert.IsNotNull(inv);
            Assert.IsTrue(inv.isLabelCorrect());

            //Verify items added to the bag and cart is opened
            Cart cart = inv.AddItemsAndOpenCart();
            Assert.IsNotNull(inv);
            Assert.IsTrue(cart.isLabelCorrect());

            //Verify user can move to checkout page
            Checkout1 c1 = cart.GoToCheckout();
            Assert.IsNotNull(c1);
            Assert.IsTrue(c1.isLabelCorrect());

            //Verify information on checkout is filled
            Checkout2 c2 = c1.EnterDataAndContinue("Geo", "Murillo", "12345");
            Assert.IsNotNull(c2);
            Assert.IsTrue(c2.isLabelCorrect());

            //Verify order can be submitted
            CheckoutComplete cc = c2.FinishOrder();
            Assert.IsNotNull(cc);
            Assert.IsTrue(cc.isLabelCorrect());
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}