﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.Tools;
using System;
using System.Collections.Generic;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class NavigationPage
    {
        private IWebDriver webdriver;

        public NavigationPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        public By navigationContainer = By.CssSelector("div.sidemenu");

        private void ClickOnMenu(string menuLabel)
        {
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementIsVisible(navigationContainer));
            IList<IWebElement> menuList = webdriver.FindElements(By.CssSelector("div.sidemenu div.clickable"));

            foreach (IWebElement menuNow in menuList)
            {
                Console.WriteLine(menuNow.Text);
                if (menuNow.Text.ToLower().Contains(menuLabel.ToLower()))
                {
                    menuNow.Click();
                    break;
                }
            }
        }
        
        public void ClickOnHeatmap()
        {
            ClickOnMenu("heatmap");
        }

    }
}
