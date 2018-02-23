using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class AbstractPage
    {
        public string GetCurrentUrlA(IWebDriver webdriver)
        {
            return webdriver.Url;
        }

        public void WaitForPageToLoad(IWebDriver webdriver)
        {
            IWait<IWebDriver> wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(30.00));
            wait.Until(driver1 => ((IJavaScriptExecutor)webdriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void WaitUntilElementVisible(IWebDriver webdriver, By elementLocator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(10.00));
                wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

        public void WaitUntilElementDisappears(IWebDriver webdriver, By elementLocator)
        {
            try
            {
                IWait<IWebDriver> wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(30.00));
                wait.Until(driver => !driver.FindElement(elementLocator).Displayed);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

        public void ClickOnElementJS(IWebDriver webdriver, IWebElement element)
        {
            ((IJavaScriptExecutor)webdriver).ExecuteScript("arguments[0].click();", element);
        }

    }
}
