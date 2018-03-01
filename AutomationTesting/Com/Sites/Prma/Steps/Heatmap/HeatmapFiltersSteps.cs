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
        HeatmapTooltipPage heatmapTooltipPage;

        public HeatmapFiltersSteps(CWebDriver driver)
        {
            webdriver = driver;
            heatmapPage = new HeatmapPage(webdriver.GetDriver());
        }

        [When(@"I open the heatmap Filter by Agency drop-down")]
        public void WhenIOpenTheHeatmapFilterByAgencyDrop_Down()
        {
            heatmapPage.ClickOnAgencyDropdown();
        }

        [Then(@"I check the number of agencies in the drop-down is correct")]
        public void ThenICheckTheNumberOfAgenciesInTheDrop_Down()
        {
            string dropdownAgencies = heatmapPage.GetNumberOfAgenciesInDropdown();
            bool isNumberCorrect = false;

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            var lines = File.ReadLines(path);
            string heatmapAgencies = lines.Skip(0).Take(1).First();

            if (heatmapAgencies.Equals(dropdownAgencies))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect, "Number of Agencies in dropdown: " + dropdownAgencies + " -- Number of Agencies on heatmap: " + heatmapAgencies);

        }

        [When(@"I select the Uncheck all option on Agency filter")]
        public void ThenISelectTheUncheckAllOptionOnAgencyFilter()
        {
            heatmapPage.ClickOnCheckUncheckAllButton();
        }

        [When(@"I select the Check all option on Agency filter")]
        public void WhenISelectTheCheckAllOptionOnAgencyFilter()
        {
            heatmapPage.ClickOnCheckUncheckAllButton();
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
    }
}
