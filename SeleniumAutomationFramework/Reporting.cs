using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;


namespace SeleniumAutomationFramework
{
    public class Reporting
    {
        public ExtentReports extent;
        public ExtentTest test;
        private static ExtentHtmlReporter htmlReporter;
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
    }
 }

