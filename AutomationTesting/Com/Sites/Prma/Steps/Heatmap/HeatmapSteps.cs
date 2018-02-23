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

        [When(@"I click on the total summary cell")]
        public void WhenIClickOnTheTotalSummaryCell()
        {
            heatmapPage.ClickOnTotalSummaryCell();
        }

        [Then(@"a modal with title '(.*)' appears")]
        public void ThenAModalWithTitleAppears(string title)
        {
            bool isDisplayed = heatmapPage.IsModalDisplayed();
            Assert.True(isDisplayed);

            string actualTitle = heatmapPage.GetModalTitle();
            Assert.AreEqual(title, actualTitle);
        }

        [Then(@"the modal appears")]
        public void ThenTheModalAppears()
        {
            bool isDisplayed = heatmapPage.IsModalDisplayed();
            Assert.True(isDisplayed);
        }

        [When(@"I click on the Close button")]
        public void WhenIClickOnTheCloseButton()
        {
            heatmapPage.ClickOnModalCloseButton();
        }

        [When(@"I click on the X button")]
        public void WhenIClickOnTheXButton()
        {
            heatmapPage.ClickOnModalXButton();
        }

        [Then(@"the modal disappears")]
        public void ThenTheModalDisappears()
        {
            bool isDisplayed = heatmapPage.IsModalDisplayed();
            Assert.False(isDisplayed);
        }

        [Then(@"the number of all requirements and KVs is correct")]
        public void ThenTheNumberOfAllRequirementsAndKVsIsCorrect(Table table)
        {
            ScenarioContext.Current.Pending();
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

            foreach(HeatmapTooltipModel dataNow in data)
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
