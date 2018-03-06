using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace AutomationTesting.Com.Sites.Prma.Pages.Strategy
{
    class DomainStrategyPage : AbstractPage
    {
        private IWebDriver webdriver;

        public DomainStrategyPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        // Header locators
        private By pageTitle = By.CssSelector(".rd-title");

        //public void ClickOnSidemenuButton()
        //{
        //    WaitForPageToLoad(webdriver);
        //    webdriver.FindElement(sidemenuButton).Click();
        //}

        public string GetCurrentUrl()
        {
            WaitForPageToLoad(webdriver);
            return GetCurrentUrlA(webdriver);
        }

        public string GetBreadcrumbs()
        {
            return GetBreadcrumbsA(webdriver);
        }

        public string GetPageTitle()
        {
            WaitForPageToLoad(webdriver);
            return webdriver.FindElement(pageTitle).Text.Trim();
        }
    }
}
