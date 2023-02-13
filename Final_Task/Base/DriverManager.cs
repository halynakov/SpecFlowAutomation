using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.Base
{
    public class DriverManager
    {
        private static IWebDriver driver;
        public static IWebDriver Instance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(40));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
