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

namespace AutomationTesting.Com.Sites.Prma.Steps.Heatmap
{
    [Binding]
    class HeatmapFiltersSteps
    {
        private CWebDriver webdriver;
        HeatmapPage heatmapPage;

        public HeatmapFiltersSteps(CWebDriver driver)
        {
            webdriver = driver;
            heatmapPage = new HeatmapPage(webdriver.GetDriver());
        }

        /********** Agency filter *****************************/
        [When(@"I open the heatmap Filter by Agency drop-down")]
        public void WhenIOpenTheHeatmapFilterByAgencyDrop_Down()
        {
            heatmapPage.ClickOnAgencyDropdown();
        }

        [Then(@"I check the number of agencies in the drop-down is correct")]
        public void ThenICheckTheNumberOfAgenciesInTheDrop_Down()
        {
            string agenciesDropdown = heatmapPage.GetNumberOfAgenciesInDropdown();
            bool isNumberCorrect = false;

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            var lines = File.ReadLines(path);
            string heatmapAgencies = lines.Skip(0).Take(1).First();

            if (heatmapAgencies.Equals(agenciesDropdown))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect, "Number of Agencies in dropdown: " + agenciesDropdown + " -- Number of Agencies on heatmap: " + heatmapAgencies);
        }

        [When(@"I select the Uncheck all option on Agency filter")]
        public void ThenISelectTheUncheckAllOptionOnAgencyFilter()
        {
            heatmapPage.ClickOnAgenciesCheckUncheckAllButton();
        }

        [When(@"I select the Check all option on Agency filter")]
        public void WhenISelectTheCheckAllOptionOnAgencyFilter()
        {
            heatmapPage.ClickOnAgenciesCheckUncheckAllButton();
        }

        [When(@"I select agency1 '(.*)' and agency2 '(.*)'")]
        public void WhenISelectAgency1AndAgency2(string agency1, string agency2)
        {
            heatmapPage.ClickOnSpecificAgency(agency1);
            heatmapPage.ClickOnSpecificAgency(agency2);
        }

        [Then(@"the agencies on the heatmap are agency1 '(.*)' and agency2 '(.*)'")]
        public void ThenISeeTheColumnsForAgency1AndAgency2(string agency1, string agency2)
        {
            List<string> agenciesList = heatmapPage.GetAgencyNamesOnHeatmap();
            Assert.AreEqual(agency1, agenciesList[0]);
            Assert.AreEqual(agency2, agenciesList[1]);
        }
        /******************************************************************/


        /********** Domain filter *****************************/
        [When(@"I open the heatmap Filter by Domain drop-down")]
        public void WhenIOpenTheHeatmapFilterByDomainDrop_Down()
        {
            heatmapPage.ClickOnDomainDropdown();
        }

        [Then(@"I check the number of domains in the drop-down is correct")]
        public void ThenICheckTheNumberOfDomainsInTheDrop_DownIsCorrect()
        {
            string domainsDropdown = heatmapPage.GetNumberOfDomainsInDropdown();
            bool isNumberCorrect = false;

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            var lines = File.ReadLines(path);
            string heatmapDomains = lines.Skip(0).Take(1).First();

            if (heatmapDomains.Equals(domainsDropdown))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect, "Number of Domains in dropdown: " + domainsDropdown + " -- Number of Domains on heatmap: " + heatmapDomains);
        }

        [When(@"I select the Uncheck all option on Domain filter")]
        public void WhenISelectTheUncheckAllOptionOnDomainFilter()
        {
            heatmapPage.ClickOnDomainsCheckUncheckAllButton();
        }

        [When(@"I select the Check all option on Domain filter")]
        public void WhenISelectTheCheckAllOptionOnDomainFilter()
        {
            heatmapPage.ClickOnDomainsCheckUncheckAllButton();
        }

        [When(@"I select domain1 '(.*)' and domain2 '(.*)'")]
        public void WhenISelectDomain1AndDomain2(string domain1, string domain2)
        {
            heatmapPage.ClickOnSpecificDomain(domain1);
            heatmapPage.ClickOnSpecificDomain(domain2);
        }

        [Then(@"the domains on the heatmap are domain1 '(.*)' and domain2 '(.*)'")]
        public void ThenISeeTheRowsForDomain1AndDomain2(string domain1, string domain2)
        {
            List<string> domainsList = heatmapPage.GetDomainNamesOnHeatmap();
            Assert.AreEqual(domain1, domainsList[0]);
            Assert.AreEqual(domain2, domainsList[1]);
        }
        /******************************************************************/


        /********** All Summaries *****************************/
        [Then(@"I see the requirement summary section and row")]
        public void ThenISeeTheRequirementSummarySectionAndRow()
        {
            bool isDisplayed = heatmapPage.IsSummaryDisplayed();
            Assert.IsTrue(isDisplayed);
        }

        [Then(@"the requirement summary section and row disappear")]
        public void ThenTheRequirementSummarySectionAndRowDisappear()
        {
            bool isDisplayed = heatmapPage.IsSummaryDisplayed();
            Assert.IsFalse(isDisplayed);
        }

        [When(@"I uncheck the All Summaries checkbox")]
        public void WhenIUncheckTheAllSummariesCheckbox()
        {
            heatmapPage.ClickOnAllSummariesCheckbox();
        }

        [When(@"I check the All Summaries checkbox")]
        public void WhenICheckTheAllSummariesCheckbox()
        {
            heatmapPage.ClickOnAllSummariesCheckbox();
        }
        /******************************************************************/

    }
}
