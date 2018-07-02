using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using System.Threading;

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
        [Test]
        public void FileUploadWithSendWait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://nervgh.github.io/pages/angular-file-upload/examples/image-preview/";
            driver.FindElement(By.XPath("//input[@type='file']")).Click();
            SendKeys.SendWait(@"C:\Users\v-sasudi\Desktop\imaheupload.png");
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(30);
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

        }
    }
}
