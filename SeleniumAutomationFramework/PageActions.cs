using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationFramework
{
    class PageActions
    {
        BasicMethods basicMethod = new BasicMethods();
        Validations validations = new Validations();

        public void navigateToHomepage(IWebDriver driver, String PageURL)
        {
            driver.Navigate().GoToUrl(PageURL);
        }
        public void Login(IWebDriver driver, String email, String password)
        {
            basicMethod.clickElement(driver, PageObjects.loginUsernameInput);
            basicMethod.sendKeys(driver, PageObjects.loginUsernameInput, email);
            basicMethod.clickElement(driver, PageObjects.loginPassInput);
            basicMethod.sendKeys(driver, PageObjects.loginPassInput,password);
            basicMethod.clickElement(driver, PageObjects.loginButton);
        }
    }
}
