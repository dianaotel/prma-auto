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
    public class ForgotPasswordSteps
    {
        private CWebDriver webdriver;
        ForgotPasswordPage forgotPasswordPage;

        public ForgotPasswordSteps(CWebDriver driver)
        {
            webdriver = driver;
            forgotPasswordPage = new ForgotPasswordPage(webdriver.GetDriver());
        }

        [Then(@"I am redirected to the page with URL '(.*)'")]
        public void ThenIAmRedirectedToTheForgotPasswordPage(string url)
        {
            string expectedUrl = ConfigurationManager.AppSettings["BaseUrl"] + url;
            string actualUrl = forgotPasswordPage.GetCurrentUrl();
            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Given(@"I click on the send button")]
        public void GivenIClickOnTheSendButton()
        {
            forgotPasswordPage.ClickOnSendButton();
        }

        [Then(@"I should see the error message '(.*)' for required email")]
        public void ThenIShouldSeeTheErrorMessageForRequiredEmail(string message)
        {
            string actualMessage = forgotPasswordPage.GetErrorOnEmptyEmail();
            Assert.AreEqual(message, actualMessage);
        }


        [Then(@"I should see the error message '(.*)' for non-existing email")]
        public void ThenIShouldSeeTheErrorMessageForNon_ExistingEmail(string message)
        {
            string actualMessage = forgotPasswordPage.GetErrorOnNonexistingEmail();
            Assert.AreEqual(message, actualMessage);
        }

        [Given(@"I click on the Back to login link")]
        public void GivenIClickOnTheBackToLoginLink()
        {
            forgotPasswordPage.ClickOnBackToLogin();
        }

    }
}
