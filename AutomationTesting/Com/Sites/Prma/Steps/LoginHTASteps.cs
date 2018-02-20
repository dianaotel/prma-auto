using AutomationTesting.Com.Configs;
using AutomationTesting.Com.Sites.Prma.Pages;
using NUnit.Framework;
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

        [Given(@"I enter email address '(.*)'")]
        public void GivenIEnterValidEmailAddress(string email)
        {
            loginPage.InputUserName(email);
            loginPage.ClickLogin();
        }

        [Then(@"I should see the error message '(.*)' for invalid email")]
        public void ThenIShouldSeeTheErrorMessage(string message)
        {
            string actualMessage = loginPage.GetInvalidEmailErrorMessage();
            Assert.AreEqual(message, actualMessage);
        }

        [Then(@"I should see the error message '(.*)' for required password")]
        public void ThenIShouldSeeTheErrorMessageForMissingPassword(string message)
        {
            string actualMessage = loginPage.GetRequiredPasswordErrorMessage();
            Assert.AreEqual(message, actualMessage);
        }

        [Given(@"I enter invalid credentials '(.*)' '(.*)'")]
        public void GivenIEnterInvalidCredentials(string email, string password)
        {
            loginPage.InputUserName(email);
            loginPage.InputUserPass(password);
            loginPage.ClickLogin();
        }

        [Then(@"I should see the error message '(.*)' for invalid credentials")]
        public void ThenIShouldSeeTheErrorMessageForInvalidCredentials(string message)
        {
            string actualMessage = loginPage.GetInvalidLoginErrorMessage();
            Assert.AreEqual(message, actualMessage);
        }

    }
}
