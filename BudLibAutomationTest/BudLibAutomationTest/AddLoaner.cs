using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace BudLibAutomationTest
{
    [TestClass]
    public class AddLoaner
    {
        [TestMethod]
        public void RunTests()
        {
            TestBase.Initialize();
            TestBase.Login("yves.pauchard@ucalgary.ca", "easypassword");
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//h6[contains(.,'Add loaners')]"));
            Thread.Sleep(2000);
            Browser.sendInput(By.XPath("//input[@id='formSchoolId']"), "testid1234");
            
            Browser.sendInput(By.XPath("//input[@id='formEmail']"), "test@test.com");

            Browser.sendInput(By.XPath("//input[@id='formFirstName']"), "Mike");

            Browser.sendInput(By.XPath("//input[@id='formMiddleName']"), "the");

            Browser.sendInput(By.XPath("//input[@id='formLastName']"), "tester");

            Browser.sendInput(By.XPath("//input[@id='formFatherName']"), "father");

            Browser.sendInput(By.XPath("//input[@id='formMotherName']"), "mother");

            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Add loaner')]"));
            Thread.Sleep(2000);
            Browser.acceptAlertIfAvailable();
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//span[contains(.,'Loaners')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//a[contains(text(),'Search loaners')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//select[@id='selectFilter']"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//select[@id='selectFilter']/option[contains(.,'Name')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//input[@id='inputFilter']"));
            Browser.sendInput(By.XPath("//input[@id='inputFilter']"), "test");
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Search')]"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//table[@id='dataTable']/tbody/tr/td/a"));
            Thread.Sleep(2000);
            Browser.elementClick(By.XPath("//button[contains(.,'Delete loaner')]"));
            Thread.Sleep(2000);
            Browser.acceptAlertIfAvailable();
            Browser.Close();

        }
    }
}
