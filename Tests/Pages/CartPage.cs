using Final_Task.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Final_Task.Pages
{
    public class CartPage : BasePage
    {
        public CartPage() { }
        private static CartPage cartpage;
        public static CartPage Instance => cartpage ?? (cartpage = new CartPage());
        IWebElement QtyButton => DriverManager.Instance().FindElement(By.XPath("//span [@class = 'a-dropdown-label']"));
        IWebElement Qty2Button => DriverManager.Instance().FindElement(By.XPath("//a [@id = 'quantity_2']"));
        IWebElement NewPrice => DriverManager.Instance().FindElement(By.XPath("//span [@class = 'a-size-medium a-color-base sc-price sc-white-space-nowrap']"));
        IWebElement DeleteButton => DriverManager.Instance().FindElement(By.XPath("//input[@value = 'Delete']"));
        IWebElement Title => DriverManager.Instance().FindElement(By.XPath("//h1"));

        public void ClickOnQtyButton()
        {
            QtyButton.Click();
        }
        public void ClickOnDeleteButton()
        {
            DeleteButton.Click();
            Thread.Sleep(1000);
        }
        public void ChangeAmountOfGoods()
        {
            Qty2Button.Click();
            Thread.Sleep(1000);
        }
        public string GetActualCart()
        {
            return NewPrice.Text;
        }
        public string GetTitle()
        {
            return Title.Text;
        }
    }
}
