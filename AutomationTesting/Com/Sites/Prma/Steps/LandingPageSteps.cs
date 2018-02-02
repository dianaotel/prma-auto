using NUnit.Framework;
using AutomationTesting.Com.Configs;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Pages;
using SemanticComparison;
using System.Configuration;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationTesting.Com.Sites.Prma.Steps
{
    [Binding]
    public class LandingPageSteps
    {
        private CWebDriver webdriver;
        LoginPage loginPage;
        LandingPage landingPage;

        public LandingPageSteps(CWebDriver driver)
        {
            webdriver = driver;
            loginPage = new LoginPage(webdriver.GetDriver());
            landingPage = new LandingPage(webdriver.GetDriver());
        }

        [Then(@"I should see the landing page")]
        public void ThenIShouldSeeTheLandingPage()
        {
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            string actualUrl = landingPage.GetCurrentUrl();
            Assert.AreEqual(baseUrl, actualUrl);
        }

        [Then(@"I should see the landing page with title '(.*)'")]
        public async Task ThenIShouldSeeTheLandingPageTitle(string title)
        {
            string actualPageTitle = await landingPage.GetPageTitle();
            Assert.AreEqual(title, actualPageTitle);
        }

        [Then(@"I should see project cards")]
        public void ThenIShouldSeeProjectCards()
        {
            bool isVisible = landingPage.IsProjectCardVisible();
            Assert.AreEqual(true, isVisible);
        }

        [Then(@"the first project card contains '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void ThenTheFirstProjectCardContains(string title, string subtitle, string description, string summary, string met, string metKV, string partial, string partialKV, string notMet, string notMetKV)
        {
            ProjectCardModel actualModel = landingPage.GetCardDetails();
            ProjectCardModel expectedModel = new ProjectCardModel();
            expectedModel.Title = title;
            expectedModel.Subtitle = subtitle;
            expectedModel.Description = description;
            expectedModel.RequirementSummary = summary;
            expectedModel.ReqMet = met;
            expectedModel.ReqMetKV = metKV;
            expectedModel.ReqPartiallyMet = partial;
            expectedModel.ReqPartiallyMetKV = partialKV;
            expectedModel.ReqNotMet = notMet;
            expectedModel.ReqNotMetKV = notMetKV;
            var expectedModelLikeness = new Likeness<ProjectCardModel, ProjectCardModel>(expectedModel);
            expectedModelLikeness.ShouldEqual(actualModel);
        }

        [When(@"I open the project '(.*)'")]
        public void WhenIOpenTheProject(string projectTitle)
        {
            landingPage.ClickOnProject(projectTitle);
        }

    }
}

