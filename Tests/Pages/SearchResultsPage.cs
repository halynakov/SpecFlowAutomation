using Final_Task.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Final_Task.Pages
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage() { }
        private static SearchResultsPage _resultsPage;
        public static SearchResultsPage Instance => _resultsPage ?? (_resultsPage = new SearchResultsPage());
        IWebElement ActualItem => DriverManager.Instance().FindElement(By.XPath("//span[@class='a-size-medium a-color-base a-text-normal']"));
        public string GetItemName()
        {
            return ActualItem.Text;
        }
    }
}
