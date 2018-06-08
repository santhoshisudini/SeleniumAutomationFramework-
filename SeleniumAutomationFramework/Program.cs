using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Configuration;
namespace SeleniumAutomationFramework
{
    class HomePage
    {
        [TestFixture]
        public class LoginTest
        {
           public static IWebDriver driver;
            PageActions pageActions = new PageActions();
            Validations validations = new Validations();
            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            [Test]
            public void SmokeTest()
            {
                string email = ConfigurationManager.AppSettings["Username"];
                string password= ConfigurationManager.AppSettings["Password"];
                pageActions.navigateToHomepage(driver, ConfigurationManager.AppSettings["Live url"]);
                pageActions.Login(driver, email, password);
            }
            [TearDown]
            public void TearDown()
            {
               driver.Quit();
            }

        }
    }
}
