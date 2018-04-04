using NUnit.Framework;
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

        [When(@"I click on the Objectives Save button")]
        public void WhenIClickOnTheObjectivesSaveButton()
        {
            projectObjectivePage.ClickOnObjectivesSaveButton();
        }

        [Then(@"the text '(.*)' is saved")]
        public void ThenTheTextIsSaved(string text)
        {
            projectObjectivePage.IsObjTextSaved(text);
        }

    }
}
