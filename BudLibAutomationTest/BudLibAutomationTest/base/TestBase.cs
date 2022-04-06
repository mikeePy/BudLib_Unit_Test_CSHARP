using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BudLibAutomationTest
{


    public class TestBase
    {
        
        public static void Initialize()
        {
            Browser.Initialize();
            
        }

        public static void Login(string user, string password)
        {
            var userx = Browser.Driver.FindElement(By.Id("email"));

            userx.SendKeys(user);

            var pass = Browser.Driver.FindElement(By.Id("password"));
            pass.SendKeys(password);

            Browser.Driver.FindElement(By.TagName("button")).Click();

        }


        public static void Cleanup()
        {
            Browser.Close();

        }



    }
}
