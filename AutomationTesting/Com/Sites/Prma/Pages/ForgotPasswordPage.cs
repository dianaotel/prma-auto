using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.Tools;
using System;
using System.Threading;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class ForgotPasswordPage : AbstractPage
    {
        private IWebDriver webdriver;

        public ForgotPasswordPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        // Inputs, buttons, links
        private By sendButton = By.CssSelector("button[type='submit']");
        private By backToLoginLink = By.CssSelector("a[href*='login']");

        // Text
        private By requiredError = By.CssSelector("span[class='error']");
        private By nonexistingEmailError = By.CssSelector("span[class='error ng-binding']");


        public string GetCurrentUrl()
        {
            WaitForPageToLoad(webdriver);
            return GetCurrentUrlA(webdriver);
        }

        public void ClickOnSendButton()
        {
            webdriver.FindElement(sendButton).Click();
        }

        public string GetErrorOnEmptyEmail()
        {
            return webdriver.FindElement(requiredError).Text;
        }

        public string GetErrorOnNonexistingEmail()
        {
            return webdriver.FindElement(nonexistingEmailError).Text;
        }

        public void ClickOnBackToLogin()
        {
            webdriver.FindElement(backToLoginLink).Click();
        }

    }
}
