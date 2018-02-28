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


        /********** Requirements modal steps ******************************************/
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

        [When(@"I click on the View requirements button")]
        public void WhenIClickOnTheViewRequirementsButton()
        {
            heatmapPage.ClickOnModalViewReqButton();
        }

        [Then(@"the total number of requirements and KVs in modal is correct")]
        public void ThenTheTotalNumberOfRequirementsAndKVsInModalIsCorrect()
        {
            var lines = File.ReadLines(@"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt");
            string reqsInPage = lines.Skip(0).Take(1).First();
            string kvsInPage = lines.Skip(1).Take(1).First();

            HeatmapModalModel model = heatmapPage.GetModalInformation();
            Assert.AreEqual(reqsInPage, model.TotalReqs);
            Assert.AreEqual(kvsInPage, model.TotalKVs);
        }

        [When(@"I click on the total requirements link")]
        public void WhenIClickOnTheTotalRequirementsLink()
        {
            heatmapPage.ClickOnModalTotalReqsLink();
        }

        [When(@"I click on the total KVs link")]
        public void WhenIClickOnTheTotalKVsLink()
        {
            heatmapPage.ClickOnModalTotalKVsLink();
        }
        /************************************************************************/

        /********** Filters steps ******************************************/

        [When(@"I save the number of agencies on the heatmap in a file")]
        public void WhenISaveTheNumberOfAgenciesOnTheHeatmapInAFile()
        {
            heatmapPage.WriteInFileNumberOfAgenciesOnHeatmap();
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

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            var lines = File.ReadLines(path);
            string heatmapAgencies = lines.Skip(0).Take(1).First();

            if (heatmapAgencies.Equals(dropdownAgencies))
            {
                isNumberCorrect = true;
            }

            Assert.IsTrue(isNumberCorrect);
        }

        [When(@"I select the Uncheck all option")]
        public void ThenISelectTheUncheckAllOption()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all agency columns disappear")]
        public void ThenAllAgencyColumnsDisappear()
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
