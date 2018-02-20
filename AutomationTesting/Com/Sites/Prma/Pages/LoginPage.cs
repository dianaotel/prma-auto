using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.Tools;
using System;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class LoginPage : AbstractPage
    {
        private IWebDriver webdriver;

        public LoginPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        // Inputs, buttons, links
        private By userNameInput = By.CssSelector("input[name='email']");
        private By userPassInput = By.CssSelector("input[name='password']");
        private By loginButton = By.CssSelector("button");
        private By forgotPasswordLink = By.CssSelector("a[href*='forgot-password']");

        // Error messages
        private By invalidEmailErrorMessage = By.CssSelector("span[class='error']");
        private By invalidLoginErrorMessage = By.CssSelector("span[class='error ng-binding']");
        private By requiredPasswordErrorMessage = By.CssSelector("span[ng-show*='password']");

        public void InputUserName(String userName)
        {
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(userNameInput));
            webdriver.FindElement(userNameInput).SendKeys(userName);
        }

        public void InputUserPass(String userPass)
        {
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(userPassInput));
            webdriver.FindElement(userPassInput).SendKeys(userPass);
        }

        public void ClickLogin()
        {
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(loginButton));
            webdriver.FindElement(loginButton).Click();
            WaitForPageToLoad(webdriver);
        }

        public string GetInvalidEmailErrorMessage()
        {
            WaitForPageToLoad(webdriver);
            return webdriver.FindElement(invalidEmailErrorMessage).Text;
        }

        public string GetRequiredPasswordErrorMessage()
        {
            WaitForPageToLoad(webdriver);
            return webdriver.FindElement(requiredPasswordErrorMessage).Text;
        }

        public string GetInvalidLoginErrorMessage()
        {
            //WaitForPageToLoad(webdriver);
            //WaitForElementToLoad(webdriver, invalidLoginErrorMessage, 20);
            WaitUntilElementVisible(webdriver, invalidLoginErrorMessage);
            return webdriver.FindElement(invalidLoginErrorMessage).Text;
        }

        public void ClickOnForgotPasswordLink()
        {
            webdriver.FindElement(forgotPasswordLink).Click();
        }

    }
}
