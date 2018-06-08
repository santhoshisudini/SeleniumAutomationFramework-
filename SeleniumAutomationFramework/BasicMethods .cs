using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationFramework
{
   public class BasicMethods
    {
      public void clickElement(IWebDriver driver,By element)
        {
            driver.FindElement(element).Click();
        }
        public void sendKeys(IWebDriver driver,By element,string keys)
        {
            driver.FindElement(element).SendKeys(keys);
        }
    }
}
