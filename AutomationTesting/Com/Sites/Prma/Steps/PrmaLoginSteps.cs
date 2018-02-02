using NUnit.Framework;
using AutomationTesting.Com.Configs;
using AutomationTesting.Com.Sites.Prma.Pages;
using System.Configuration;
using TechTalk.SpecFlow;

namespace AutomationTesting.Com.Sites.Prma.Steps
{
    [Binding]
    public class PrmaLoginSteps
    {
        private CWebDriver webdriver;
        LoginPage loginPage;

        public PrmaLoginSteps(CWebDriver driver)
        {
            webdriver = driver;
        }

        [When(@"I go to heatmap")]
        public void WhenIGoToHeatmap()
        {
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            webdriver.GetDriver().Navigate().GoToUrl(baseUrl + "/heatmap");
            Assert.AreSame("are", "there");
        }

    }
}
