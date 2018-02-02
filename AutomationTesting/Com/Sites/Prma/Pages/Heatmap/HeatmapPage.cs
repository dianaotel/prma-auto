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
    class HeatmapPage
    {
        private IWebDriver webdriver;

        public HeatmapPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        private By sidemenuButton = By.CssSelector("a[ng-href='/heatmap']");

        // cell locators
        private By totalSummaryCell = By.CssSelector(".total-summary-cell .cell");
        private By cellListLocator = By.CssSelector(".data-cells span.cell");
        private By statusElementsLocator = By.CssSelector("div[class*='status']");

        //modal locators
        private By modal = By.CssSelector(".modal-heatmap-cell");
        private By modalTitle = By.CssSelector(".modal-heatmap-cell h3");
        
        // cell tooltip locators
        private By cellTooltipLocator = By.CssSelector(".heatmap-data-cell-tooltip");
        private By tooltipHeaderLocator = By.CssSelector(".heatmap-data-cell-tooltip .header");

        public void ClickOnSidemenuButton()
        {
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

            IList<IWebElement> statusAreas = cell.FindElements(statusElementsLocator);

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
