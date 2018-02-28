using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Steps;
using AutomationTesting.Com.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Pages.Requirements
{
    class RequirementsPage : AbstractPage
    {
        private IWebDriver webdriver;

        public RequirementsPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        private By sidemenuButton = By.CssSelector("a[ng-href='/start']");

        // Header locators
        private By pageTitle = By.CssSelector(".page-header .rd-title");


        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public string GetPageTitle()
        {
            return webdriver.FindElement(pageTitle).Text;
        }
    }
}
