//using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace AutomationTesting.Com.Sites.Prma.Steps
{
    [Binding]
    public class HeatmapSteps
    {
        private CWebDriver webdriver;
        HeatmapPage heatmapPage;
        HeatmapTooltipPage heatmapTooltipPage;

        public HeatmapSteps(CWebDriver driver)
        {
            webdriver = driver;
            heatmapPage = new HeatmapPage(webdriver.GetDriver());
        }

        [When(@"I navigate to the heatmap")]
        public void WhenINavigateToTheHeatmap()
        {
            heatmapPage.ClickOnSidemenuButton();
        }

        [Then(@"I should see the heatmap page with URL '(.*)' and title '(.*)'")]
        public void ThenIShouldSeeTheHeatmapPageWithUlrAndTitle(string url, string title)
        {
            string expectedUrl = ConfigurationManager.AppSettings["baseUrl"] + url;
            string actualUrl = heatmapPage.GetCurrentUrl();
            Assert.AreEqual(expectedUrl, actualUrl);

            string actualPageTitle = heatmapPage.GetPageTitle();
            Assert.AreEqual(title, actualPageTitle);
        }

        [Then(@"the breadcrumbs '(.*)' are correct")]
        public void ThenTheBreadcrumbsAreCorrect(string breadcrumbs)
        {
            string actualBreadcrumbs = heatmapPage.GetBreadcrumbs();
            Assert.AreEqual(breadcrumbs, actualBreadcrumbs);
        }

        [Then(@"I see agency columns")]
        public void ThenISeeAgencyColumns()
        {
            bool areAgenciesDisplayed = heatmapPage.AreAgencyColumnsDisplayed();
            Assert.IsTrue(areAgenciesDisplayed);
        }

        [Then(@"all agency columns disappear")]
        public void ThenAllAgencyColumnsDisappear()
        {
            bool areAgenciesDisplayed = heatmapPage.AreAgencyColumnsDisplayed();
            Assert.IsFalse(areAgenciesDisplayed);
        }

        [When(@"I save the number of agencies on the heatmap in a file")]
        public void WhenISaveTheNumberOfAgenciesOnTheHeatmapInAFile()
        {
            heatmapPage.WriteInFileNumberOfAgenciesOnHeatmap();
        }

        [When(@"I save the number of domains on the heatmap in a file")]
        public void WhenISaveTheNumberOfDomainsOnTheHeatmapInAFile()
        {
            heatmapPage.WriteInFileNumberOfDomainsOnHeatmap();
        }

        [Then(@"the total number of requirements and KVs on the page is saved in file")]
        public void ThenTheTotalNumberOfRequirementsAndKVsIsSavedInFile()
        {
            heatmapPage.WriteInFileTotalReqsAndKVsOnPage();
        }

        [When(@"I click on the total summary cell")]
        public void WhenIClickOnTheTotalSummaryCell()
        {
            heatmapPage.ClickOnTotalSummaryCell();
        }

        

























        [When(@"I select a coloured cell '(.*)'")]
        public void WhenISelectAColouredCell(string requirementsNumber)
        {
            heatmapPage.GrabCellsColorsData();
        }

        [When(@"I select a coloured cell with '(.*)' colors")]
        public void WhenISelectAColouredCellWithColors(int colorCount)
        {
            Boolean isFound = heatmapPage.ClickOnColouredCell(colorCount);
            Assert.True(isFound);
        }

        [Then(@"I check the number of each requirement")]
        public void ThenICheckTheNumberOfEachRequirement()
        {
            heatmapTooltipPage = new HeatmapTooltipPage(webdriver.GetDriver());
            IList<HeatmapTooltipModel> data = heatmapTooltipPage.GrabTooltipData();

            foreach (HeatmapTooltipModel dataNow in data)
            {
                Console.WriteLine("ItemData: {0}", dataNow.ToStr());

                //check color data
                webdriver.GetDriver().Navigate().GoToUrl(dataNow.colorLink);
                RequirementsListPage requirementsListPage = new RequirementsListPage(webdriver.GetDriver());
                var actualColorCount = requirementsListPage.GrabItemCount();
                Assert.AreEqual(Convert.ToInt32(dataNow.colorText), actualColorCount);

                //check vulnerability data
                webdriver.GetDriver().Navigate().GoToUrl(dataNow.vulnerabilityLink);
                var actualVulnerabilityCount = requirementsListPage.GrabItemCount();
                Assert.AreEqual(Convert.ToInt32(dataNow.vulnerabilityText), actualVulnerabilityCount);

            }
        }




    }
}
