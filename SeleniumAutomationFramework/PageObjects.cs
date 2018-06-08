using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationFramework
{
    class PageObjects
    {
        // Login screen objects 
        public static By loginUsernameInput = By.Id("txtUsername");
        public static By loginPassInput = By.Id("txtPassword");
        public static By loginButton = By.Id("btnLogin");
    }
}
