using AutomationTesting.Com.Configs;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Pages;
using System;
using System.IO;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Configuration;
using AutomationTesting.Com.Sites.Prma.Pages.Requirements;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Steps.Requirements
{
    [Binding]
    class RequirementsSteps
    {
        private CWebDriver webdriver;
        RequirementsPage requirementsPage;


        public RequirementsSteps(CWebDriver driver)
        {
            webdriver = driver;
            requirementsPage = new RequirementsPage(webdriver.GetDriver());
        }


        [Then(@"I am redirected to the requirements page '(.*)'")]
        public void ThenIAmRedirectedToTheRequirementsPage(string url)
        {
            string currentUrl = requirementsPage.GetCurrentUrl();
            Assert.IsTrue(currentUrl.Contains(url));
        }

        [Then(@"the Requirements page title contains the total number of requirements")]
        public void ThenTheRequirementsPageTitleContainsTheTotalNumberOfRequirements()
        {
            string actualTitle = requirementsPage.GetPageTitle();

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            var lines = File.ReadLines(path);
            string reqsNumber = "(" + lines.Skip(0).Take(1).First() + ")";

            Assert.IsTrue(actualTitle.Contains(reqsNumber), "Title espected to contain: " + reqsNumber + " -- Actual title: " + actualTitle);
        }

        [Then(@"the Requirements page title contains the total number of KVs")]
        public void ThenTheRequirementsPageTitleContainsTheTotalNumberOfKVs()
        {
            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            string actualTitle = requirementsPage.GetPageTitle();

            var lines = File.ReadLines(path);
            string kvsNumber = "(" + lines.Skip(1).Take(1).First() + ")";

            Assert.IsTrue(actualTitle.Contains(kvsNumber), "Expected number of KVs in title: " + kvsNumber + " -- Actual title: " + actualTitle);
        }

    }
}
