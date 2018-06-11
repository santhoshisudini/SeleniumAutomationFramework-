using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
namespace SeleniumAutomationFramework
{
    class SeleniumOperations
    {
        [Test]
        public void FileUpload()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/upload/";
            IWebElement UploadElement = driver.FindElement(By.Id("uploadfile_0"));
            UploadElement.SendKeys(@"C:\Users\v-sasudi\Desktop\sample.txt");
            driver.FindElement(By.Id("terms")).Click();
            driver.FindElement(By.Id("submitbutton")).Click();
        }

    }
}
