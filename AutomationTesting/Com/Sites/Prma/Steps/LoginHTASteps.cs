using AutomationTesting.Com.Configs;
using AutomationTesting.Com.Sites.Prma.Pages;
using System.Configuration;
using TechTalk.SpecFlow;

namespace AutomationTesting.Com.Sites.Prma.Steps
{
    [Binding]
    public class LoginHTASteps
    {
        private CWebDriver webdriver;
        LoginPage loginPage;
        LandingPage landingPage;

        public LoginHTASteps(CWebDriver driver)
        {
            webdriver = driver;
            loginPage = new LoginPage(webdriver.GetDriver());
        }

        [Given(@"I navigate to the login URL")]
        public void GivenINavigateToTheLoginUrl()
        {
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            webdriver.GetDriver().Navigate().GoToUrl(baseUrl + "login");
        }
        
        [Given(@"I enter valid prma admin credentials")]
        public void GivenIEnterValidPrmaAdminCredentials()
        {
            var userName = ConfigurationManager.AppSettings["prmaAdminUser"];
            var userPass = ConfigurationManager.AppSettings["prmaAdminPass"];

            loginPage.InputUserName(userName);
            loginPage.InputUserPass(userPass);
            loginPage.ClickLogin();
        }

        [Given(@"I enter valid client admin credentials")]
        public void GivenIEnterValidClientAdminCredentials()
        {
            var userName = ConfigurationManager.AppSettings["clientAdminUser"];
            var userPass = ConfigurationManager.AppSettings["clientAdminPass"];

            loginPage.InputUserName(userName);
            loginPage.InputUserPass(userPass);
            loginPage.ClickLogin();
        }

    }
}
