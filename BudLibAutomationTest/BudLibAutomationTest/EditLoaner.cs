using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace BudLibAutomationTest
{
    [TestClass]
    public class EditLoaner
    {
        [TestMethod]
        public void RunTests()
        {
            TestBase.Initialize();
            TestBase.Login("", ""); //enter authentication details here (username, password)
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//h6[contains(.,'Search loaners')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//a[contains(.,'1')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Edit details')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//input[@id='formEmail']"));
            Thread.Sleep(2000);
            Browser.sendInput(By.XPath("//input[@id='formEmail']"), "test@test.com");
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Update')]"));
            Thread.Sleep(2000);
            Browser.acceptAlertIfAvailable();
            Thread.Sleep(2000);
            Assert.IsTrue(Browser.IsTextinElementsList(By.XPath("//tr[8]/td"), "test@test.com"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Edit details')]"));
            Thread.Sleep(2000);
            Browser.elementClear(By.XPath("//input[@id='formEmail']"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Update')]"));
            Thread.Sleep(2000);
            Browser.acceptAlertIfAvailable();

            
            Browser.Close();

        }
    }
}
