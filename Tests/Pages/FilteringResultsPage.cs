using Final_Task.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Final_Task.Pages
{
    public class FilteringResultsPage : BasePage
    {
        public FilteringResultsPage() { }
        private static FilteringResultsPage filter_page;
        public static FilteringResultsPage Instance => filter_page ?? (filter_page = new FilteringResultsPage());
        IWebElement ProductName => DriverManager.Instance().FindElement(By.XPath("//span[@class = 'a-size-base-plus a-color-base a-text-normal']"));
        IWebElement ProductPrice => DriverManager.Instance().FindElement(By.XPath("//span[@class = 'a-price-whole']"));
        public string GetProductName()
        {
            return ProductName.Text;
        }
        public string GetProductPrice()
        {
            return ProductPrice.Text;
        }
        public void ClickOnProductNameButton()
        {
            ProductName.Click();
            Thread.Sleep(2000);
        }
    }
}
