using Final_Task.Base;
using OpenQA.Selenium;
using System.Threading;

namespace Final_Task.Pages
{
    public class ItemPage : BasePage
    {
        public ItemPage() { }
        private static ItemPage _item_page;
        public static ItemPage Instance => _item_page ?? (_item_page = new ItemPage());
        IWebElement AddCartButton => DriverManager.Instance().FindElement(By.XPath("//input[@id='add-to-cart-button']"));
        IWebElement GoToCartButton => DriverManager.Instance().FindElement(By.XPath("//input[@aria-labelledby='attach-sidesheet-view-cart-button-announce']"));
        IWebElement AmountItemsOnCart => DriverManager.Instance().FindElement(By.XPath("//span[@id='nav-cart-count']"));
        public void AddToCart()
        {
            HomePage.Instance.ClickLocationButton();
            HomePage.Instance.ChangeLocationButton();
            HomePage.Instance.ClickDoneButton();
            AddCartButton.Click();
            Thread.Sleep(3000);
        }
        public string GetAmountOfItemsInCart()
        {
            return AmountItemsOnCart.Text;
        }
        public void GoToTheCart()
        {
            GoToCartButton.Click();
            Thread.Sleep(2000);
        }
    }
}
