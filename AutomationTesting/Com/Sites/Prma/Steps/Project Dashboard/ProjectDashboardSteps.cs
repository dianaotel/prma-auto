using AutomationTesting.Com.Configs;
using AutomationTesting.Com.Sites.Prma.Pages;
using AutomationTesting.Com.Sites.Prma.Pages.Project_Dashboard;
using NUnit.Framework;
using System.Configuration;
using TechTalk.SpecFlow;

namespace AutomationTesting.Com.Sites.Prma.Steps.Project_Dashboard
{
    [Binding]
    class ProjectDashboardSteps
    {
        private CWebDriver webdriver;
        ProjectDashboardPage projectDashboardPage;

        public ProjectDashboardSteps(CWebDriver driver)
        {
            webdriver = driver;
            projectDashboardPage = new ProjectDashboardPage(webdriver.GetDriver());
        }
    }
}
