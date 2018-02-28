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


        [Then(@"I am redirected to the requirements page")]
        public void ThenIAmRedirectedToTheRequirementsPage()
        {
            string currentUrl = requirementsPage.GetCurrentUrl();
            bool isRequirementsPage = false;

            if (currentUrl.Contains("/start"))
            {
                isRequirementsPage = true;
            }

            Assert.IsTrue(isRequirementsPage);
        }

        [Then(@"the Requirements page title contains the total number of requirements")]
        public void ThenTheRequirementsPageTitleContainsTheTotalNumberOfRequirements()
        {
            string actualTitle = requirementsPage.GetPageTitle();
            bool isNumberCorrect = false;

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            var lines = File.ReadLines(path);
            string reqsNumber = "(" + lines.Skip(0).Take(1).First() + ")";

            if (actualTitle.Contains(reqsNumber))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect);
        }

        [Then(@"the Requirements page title contains the total number of KVs")]
        public void ThenTheRequirementsPageTitleContainsTheTotalNumberOfKVs()
        {
            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            string actualTitle = requirementsPage.GetPageTitle();
            bool isNumberCorrect = false;

            var lines = File.ReadLines(path);
            string kvsNumber = "(" + lines.Skip(1).Take(1).First() + ")";

            if (actualTitle.Contains(kvsNumber))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect, "Expected number of KVs in title: " + kvsNumber + " -- Actual title: " + actualTitle);
        }

    }
}
