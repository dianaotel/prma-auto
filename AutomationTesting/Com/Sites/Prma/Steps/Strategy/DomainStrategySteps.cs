using AutomationTesting.Com.Configs;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Pages;
using AutomationTesting.Com.Sites.Prma.Pages.Heatmap;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Configuration;
using System.IO;
using System.Linq;
using AutomationTesting.Com.Sites.Prma.Pages.Strategy;

namespace AutomationTesting.Com.Sites.Prma.Steps.Strategy
{
    [Binding]
    class DomainStrategySteps
    {
        private CWebDriver webdriver;
        DomainStrategyPage domainStrategyPage;

        public DomainStrategySteps(CWebDriver driver)
        {
            webdriver = driver;
            domainStrategyPage = new DomainStrategyPage(webdriver.GetDriver());
        }

        [Then(@"I am redirected to the Domain Strategy page '(.*)'")]
        public void ThenIAmRedirectedToTheDomainStrategyPage(string url)
        {
            string expectedContainedURL = ConfigurationManager.AppSettings["BaseUrl"] + url;
            string actualURL = domainStrategyPage.GetCurrentUrl();
            Assert.IsTrue(actualURL.Contains(expectedContainedURL));
        }

    }
}
