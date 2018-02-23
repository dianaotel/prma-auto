using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Sites.Prma.Steps;
using AutomationTesting.Com.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class HeatmapPage : AbstractPage
    {
        private IWebDriver webdriver;

        public HeatmapPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        private By sidemenuButton = By.CssSelector("a[ng-href='/heatmap']");

        // Header locators
        private By pageTitle = By.CssSelector(".page-header .rd-title");
        
        // Cell locators
        private By totalSummaryCell = By.CssSelector(".total-summary-cell .cell");
        private By cellListLocator = By.CssSelector(".data-cells span.cell");
        private By statusElements = By.CssSelector("div[class*='status']");

        // Modal locators
        private By modal = By.CssSelector(".modal-heatmap-cell");
        private By modalTitle = By.CssSelector(".modal-heatmap-cell h3");
        private By modalCloseButton = By.CssSelector(".modal-heatmap-cell rd-app-button[text='Close'] .rd-app-button");
        private By modalXButton = By.CssSelector(".ngdialog-close");
        
        // Cell tooltip locators
        private By cellTooltip = By.CssSelector(".heatmap-data-cell-tooltip");
        private By tooltipHeader = By.CssSelector(".heatmap-data-cell-tooltip .header");

        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public string GetPageTitle()
        {
            WaitForPageToLoad(webdriver);
            return webdriver.FindElement(pageTitle).Text.Trim();
        }

        public void ClickOnSidemenuButton()
        {
            WaitForPageToLoad(webdriver);
            webdriver.FindElement(sidemenuButton).Click();
        }

        public void ClickOnTotalSummaryCell()
        {
            webdriver.FindElement(totalSummaryCell).Click();
        }

        public bool IsModalDisplayed()
        {
            try
            {
                return webdriver.FindElement(modal).Displayed;
            }
            catch
            {
                return false;
            }
        }

        public string GetModalTitle()
        {
            return webdriver.FindElement(modalTitle).Text.Trim();
        }

        public void ClickOnModalCloseButton()
        {
            webdriver.FindElement(modalCloseButton).Click();
        }

        public void ClickOnModalXButton()
        {
            IWebElement xButton = webdriver.FindElement(modalXButton);
            ClickOnElementJS(webdriver, xButton);
        }

        public string





        public void GrabCellsColorsData()
        {
            IList<HeatmapCellModel> results = new List<HeatmapCellModel>(); 

            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[ng-show='heatmap.showSummaries']")));
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(cellListLocator));
            IList<IWebElement> cellList = webdriver.FindElements(cellListLocator);

            foreach(IWebElement elementNow in cellList)
            {
                HeatmapCellModel itemData = GetCellInformation(elementNow);
                results.Add(itemData);
            }
        }

        internal Boolean ClickOnColouredCell(int colorCount)
        {
            Boolean isFound = false;
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[ng-show='heatmap.showSummaries']")));
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(cellListLocator));
            IList<IWebElement> cellList = webdriver.FindElements(cellListLocator);

            foreach (IWebElement elementNow in cellList)
            {
                HeatmapCellModel itemData = GetCellInformation(elementNow);

                if(itemData.CalculateVisibleColors() == colorCount)
                {
                    elementNow.Click();
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        public HeatmapCellModel GetCellInformation(IWebElement cell)
        {
            HeatmapCellModel result = new HeatmapCellModel();

            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(cell));

            IList<IWebElement> statusAreas = cell.FindElements(statusElements);

            foreach(IWebElement color in statusAreas)
            {
                var colorRawKey = color.GetAttribute("class");
                var colorRawValue = color.GetAttribute("style");

                var colorKey = colorRawKey.Replace("status-", "");
                var colorValue = colorRawValue
                    .Replace("width: 100%; height: ", "")
                    .Replace("%;", "")
                    .Replace("width: 0px; height: ", "")
                    .Replace("px;","")
                    .Trim();
                
                result.colors.Add(colorKey, colorValue);
            }
            result.CalculateVisibleColors();

            return result;
        }



    }
}
