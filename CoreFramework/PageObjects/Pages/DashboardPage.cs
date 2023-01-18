using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.PageObjects.Pages
{
    public class DashboardPage : PageObjects
    {
        public IWebElement element => driver.FindElement(By.XPath(""));
        public IWebElement element1 => driver.FindElement(By.XPath(""));
        public IWebElement element2 => driver.FindElement(By.XPath(""));
        public IWebElement element3 => driver.FindElement(By.XPath(""));
        public IWebElement element4 => driver.FindElement(By.XPath(""));
        public IWebElement element5 => driver.FindElement(By.XPath(""));
    }
}
