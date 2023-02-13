using Final_Task.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Task.Pages
{
    public class ProductsCategoryPage : BasePage
    {
        public ProductsCategoryPage() { }
        private static ProductsCategoryPage _productsPage;
        public static ProductsCategoryPage Instance => _productsPage ?? (_productsPage = new ProductsCategoryPage());
        IWebElement SelectedBrand => DriverManager.Instance().FindElement(By.XPath("//span[@class = 'a-size-base a-color-base' and text() = 'Marvel']"));
        public void FilteringByBrand()
        {
            SelectedBrand.Click();
        }
    }
}
