using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace BudLibAutomationTest
{
    public static class Browser
    {
        private static IWebDriver driver = new ChromeDriver();
        private static string bUrl = "http://localhost:3000";
        public static ISearchContext Driver { get { return driver; } }
        public static string Title { get { return driver.Title; } }

        public static IWebDriver getDriver()
        {
            return driver;
        }
        public static void Initialize()
        {
            Goto("");
        }

        public static void Close()
        {
            driver.Quit();
        }

        public static void Goto(string rUrl)
        {
            driver.Navigate().GoToUrl(string.Format("{0}/{1}", bUrl,rUrl));
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsTextinElementsList(By by, string text)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IList<IWebElement> selectElements = driver.FindElements(by);
            foreach (IWebElement element in selectElements)
            {
                if (element.Text == text) { return true; }
            }

            return false;
        }

        public static void elementClick(By by)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement selectedElement = driver.FindElement(by);
            if (selectedElement != null)
            {
                selectedElement.Click();
            }

        }

        public static void elementClear(By by)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement selectedElement = driver.FindElement(by);
            if (selectedElement != null)
            {
                selectedElement.Clear();
            }

        }

        public static void sendInput(By by, string message)
        {
            IWebElement selectedElement = driver.FindElement(by);
            selectedElement.SendKeys(message);
        }

        public static void acceptAlertIfAvailable()
        {
            driver.SwitchTo().Alert().Accept();


        }

        public static void selectDropDownByText(By by, string text)
        {
            IWebElement DropDownElement = driver.FindElement(by);
            SelectElement Selected = new SelectElement(DropDownElement);
            Selected.SelectByText(text);
        }

    }
}
