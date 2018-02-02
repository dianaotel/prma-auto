//using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTesting.Com.Configs;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Pages;
using AutomationTesting.Com.Sites.Prma.Pages.Heatmap;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;

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

        [When(@"I select a coloured cell '(.*)'")]
        public void WhenISelectAColouredCell(string requirementsNumber)
        {
            heatmapPage.GrabCellsColorsData();
        }

        [When(@"I select a coloured cell with '(.*)' colors")]
        public void WhenISelectAColouredCellWithColors(int colorCount)
        {
            Boolean isFound = heatmapPage.ClickOnColouredCell(colorCount);
            Assert.IsTrue(isFound);
        }
        
        [When(@"I check the number of each requirement")]
        public void WhenICheckTheNumberOfEachRequirement()
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

        [When(@"I click on the total summary cell")]
        public void WhenIClickOnTheTotalSummaryCell()
        {
            heatmapPage.ClickOnTotalSummaryCell();
        }

        [Then(@"a modal with '(.*)' appears")]
        public void ThenAModalWithAppears(string title)
        {
            bool isDisplayed = heatmapPage.IsModalDisplayed();
            Assert.True(isDisplayed);
            string actualTitle = heatmapPage.GetModalTitle();
            Assert.AreEqual(title, actualTitle.Trim());
        }


    }
}
