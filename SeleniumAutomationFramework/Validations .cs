using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace SeleniumAutomationFramework
{
    public class Validations
    {
        public void validateScreenByUrl(IWebDriver driver, String screenUrl)
        {
            String currentURL = driver.Url;
            Assert.IsTrue(currentURL.Equals(screenUrl));
        }
        public void validateElementIsPresent(IWebDriver driver, By element)
        {
            IWebElement findElement = driver.FindElement(element);
            Assert.IsTrue(findElement.Displayed);
        }
        public void validateTextInElement(IWebDriver driver, By element, String text)
        {
            String findElement = driver.FindElement(element).Text;
            Assert.IsTrue(findElement.Equals(text));
        }
    }
}
