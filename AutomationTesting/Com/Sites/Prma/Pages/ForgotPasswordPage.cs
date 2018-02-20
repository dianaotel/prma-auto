using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.Tools;
using System;

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

        // Text
        private By nonexistingEmailError = By.CssSelector("span[class='error ng-binding']");


        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public void ClickOnSendButton()
        {
            webdriver.FindElement(sendButton).Click();
        }

        public string GetErrorOnNonexistingEmail()
        {
            return webdriver.FindElement(nonexistingEmailError).Text;
        }
    }
}
