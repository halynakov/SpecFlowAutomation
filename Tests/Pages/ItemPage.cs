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
        IWebElement CartButton => DriverManager.Instance().FindElement(By.XPath("//input[@name='submit.add-to-cart']"));
        IWebElement AmountItemsOnCart => DriverManager.Instance().FindElement(By.XPath("//span[@id='nav-cart-count']"));
        IWebElement Cart_Button => DriverManager.Instance().FindElement(By.XPath("//a[contains(text(),'Go to Cart')]"));
        public void AddToCart()
        {
            HomePage.Instance.ClickLocationButton();
            HomePage.Instance.ChangeLocationButton();
            HomePage.Instance.ClickDoneButton();
            CartButton.Click();
        }
        public string GetAmountOfItemsInCart()
        {
            return AmountItemsOnCart.Text;
        }
        public void GoToTheCart()
        {
            Cart_Button.Click();
        }
    }
}
