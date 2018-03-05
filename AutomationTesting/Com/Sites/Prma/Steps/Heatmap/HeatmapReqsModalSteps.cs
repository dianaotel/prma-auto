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
    class HeatmapReqsModalSteps
    {
        private CWebDriver webdriver;
        HeatmapPage heatmapPage;

        public HeatmapReqsModalSteps(CWebDriver driver)
        {
            webdriver = driver;
            heatmapPage = new HeatmapPage(webdriver.GetDriver());
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
    }
}
