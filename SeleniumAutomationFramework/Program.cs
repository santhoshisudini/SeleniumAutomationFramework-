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
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework.Interfaces;
using SeleniumAutomationFramework;

namespace SeleniumAutomationFramework
{
    [TestFixture]
    public class HomePage
    {
        public IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;
        private static ExtentHtmlReporter htmlReporter;
        PageActions pageactions = new PageActions();
        BasicMethods basicmethos = new BasicMethods();

        [OneTimeSetUp]
        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\MyOwnReport.html";
            htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Configuration().Theme = Theme.Dark;
            htmlReporter.Configuration().DocumentTitle = "QA Document";

            htmlReporter.Configuration().ReportName = "QA Document";
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

        }
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
            string password = ConfigurationManager.AppSettings["Password"];
            test = extent.CreateTest("Passing test");
            pageactions.navigateToHomepage(driver, ConfigurationManager.AppSettings["Live Url"]);
            test.Log(Status.Info, "Navigated to the page");
            pageactions.Login(driver, email, password);
            test.Log(Status.Info, "User Logged in to page");
            Assert.AreEqual(driver.FindElement(By.Id("account-name")).Text, "Jacqueline Whitedds");
        }

        [TearDown]
        public void TearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                string screenShotPath = BasicMethods.Capture(driver, "ScreenShotName");
                test.Log(Status.Fail, stackTrace + errorMessage);
                test.Log(Status.Fail, "Snapshot below: " + test.AddScreenCaptureFromPath(screenShotPath));
            }

        }
        [OneTimeTearDown]
        public void GenerateReport()
        {
            driver.Quit();
            extent.Flush();
        }
    }
}
