﻿using NUnit.Framework;
using AutomationTesting.Com.Configs;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Pages;
using SemanticComparison;
using System.Configuration;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AutomationTesting.Com.Sites.Prma.Pages.Project_Details;

namespace AutomationTesting.Com.Sites.Prma.Steps.Project_Details
{
    [Binding]
    class ProjectObjectiveSteps
    {
        private CWebDriver webdriver;
        ProjectObjectivePage projectObjectivePage;

        public ProjectObjectiveSteps(CWebDriver driver)
        {
            webdriver = driver;
            projectObjectivePage = new ProjectObjectivePage(webdriver.GetDriver());
        }

        [When(@"I navigate to the Project Objective page '(.*)'")]
        public void WhenINavigateToTheProjectObjectivePage(string url)
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            projectObjectivePage.NavigateToUrl(baseUrl + url);
        }

        [Then(@"I should see the the Project Objective page with URL '(.*)' and title '(.*)'")]
        public void ThenIShouldSeeTheTheProjectObjectivePageWithURLAndTitle(string url, string title)
        {
            string actualUrl = projectObjectivePage.GetCurrentUrlA(webdriver.GetDriver());
            Assert.IsTrue(actualUrl.Contains(url), "URL is expected to contain: " + url + " -- Actual url: " + actualUrl);

            string actualTitle = projectObjectivePage.GetPageTitle();
            Assert.AreEqual(title, actualTitle);
        }


        /**************** Objectives ******************************/
        [When(@"I click on the Objectives edit button")]
        public void WhenIClickOnTheObjectivesEditButton()
        {
            projectObjectivePage.ClickOnObjEditButton();
        }

        [Then(@"the Objectives editor is displayed")]
        public void ThenTheObjectivesEditorIsDisplayed()
        {
            bool isDisplayed = projectObjectivePage.IsObjEditorVisible();
            Assert.IsTrue(isDisplayed);
        }

        [When(@"I write text '(.*)' inside the Objectives editor")]
        public void WhenIWriteTextInsideTheObjectivesEditor(string text)
        {
            projectObjectivePage.WriteTextInObjectivesEditor(text);
        }

        [When(@"I clear the Objectives text")]
        public void WhenIClearTheObjectivesText()
        {
            projectObjectivePage.ClearObjectivesText();
        }

        [When(@"I click on the Objectives Save button")]
        public void WhenIClickOnTheObjectivesSaveButton()
        {
            projectObjectivePage.ClickOnObjectivesSaveButton();
        }

        [Then(@"the Objectives text '(.*)' is saved")]
        public void ThenTheObjectivesTextIsSaved(string text)
        {
            bool isSaved = projectObjectivePage.IsObjTextSaved(text);
            Assert.IsTrue(isSaved);
        }

        [When(@"I click on the Objectives Cancel button")]
        public void WhenIClickOnTheObjectivesCancelButton()
        {
            projectObjectivePage.ClickOnObjectivesCancelButton();
        }

        [Then(@"the Objectives text '(.*)' is not saved")]
        public void ThenTheObjectivesTextIsNotSaved(string text)
        {
            bool isSaved = projectObjectivePage.IsObjTextSaved(text);
            Assert.IsFalse(isSaved);
        }

        /********************************************************/


        /**************** Methodology ****************************/
        /********************************************************/

    }
}
