using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace PageFactoryAlternative
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        private IWebElement fooElement
        {
            get
            {
                return driver.FindElement(By.Id("foo"));
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            fooElement.Click();            
        }
    }
}
