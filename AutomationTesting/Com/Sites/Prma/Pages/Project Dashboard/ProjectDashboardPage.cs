using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Tools;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Pages.Project_Dashboard
{
    class ProjectDashboardPage : AbstractPage
    {
        private IWebDriver webdriver;

        public ProjectDashboardPage(IWebDriver driver)
        {
            webdriver = driver;
        }
    }
}
