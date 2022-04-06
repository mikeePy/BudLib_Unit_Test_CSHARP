using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BudLibAutomationTest
{
    [TestClass]
    public class InvalidUserLogin
    {
        [TestMethod]
        public void RunTests()
        {
            TestBase.Initialize();
            TestBase.Login("bademail", "badpassword");

            var menuItem = Browser.IsTextinElementsList(By.TagName("h1"), "Login to BudLib");
            Assert.IsTrue(menuItem, "Element found");
            Browser.Close();

        }
    }
}
