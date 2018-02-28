using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

        // Filters locators
        private By agencyDropdown = By.CssSelector(".filter span[items='heatmap.agencies']");
        private By agenciesInDropdownList = By.CssSelector(".filter span[items='heatmap.agencies'] .items .item");


        // Left-side panel locators
        private By totalDomains = By.CssSelector(".left-side .summary-row:nth-child(1) .value");
        private By totalRequirements = By.CssSelector(".left-side .summary-row:nth-child(2) .value");
        private By totalKVs = By.CssSelector(".left-side .summary-row:nth-child(3) .value");

        // Cell locators
        private By agencyCellsList = By.CssSelector(".right-container .agency-cell");
        private By totalSummaryCell = By.CssSelector(".total-summary-cell .cell");
        private By cellListLocator = By.CssSelector(".data-cells span.cell");
        private By statusElements = By.CssSelector("div[class*='status']");

        // Modal locators
        private By modal = By.CssSelector(".modal-heatmap-cell");
        private By modalTitle = By.CssSelector(".modal-heatmap-cell h3");
        private By modalCloseButton = By.CssSelector(".modal-heatmap-cell rd-app-button[text='Close'] .rd-app-button");
        private By modalXButton = By.CssSelector(".ngdialog-close");
        private By modalViewReqButton = By.CssSelector("rd-app-button[text='View requirements']");
        private By modalTotalReqs = By.CssSelector("a[ng-href='/start?selectedView=0&displayType=3'] strong");
        private By modalTotalKVs = By.CssSelector("a[ng-href='/start?key=true&selectedView=0&displayType=3'] strong");
        private By modalNotMetReqs = By.CssSelector("a[ng-href='/start?status=2&selectedView=0&displayType=3'] span");
        private By modalNotMetKVs = By.CssSelector("a[ng-href='/start?status=2&key=true&selectedView=0&displayType=3'] strong");
        private By modalPartialReqs = By.CssSelector("a[ng-href='/start?status=3&selectedView=0&displayType=3'] span");
        private By modalPartialKVs = By.CssSelector("a[ng-href='/start?status=3&key=true&selectedView=0&displayType=3'] strong");
        private By modalMetReqs = By.CssSelector("a[ng-href='/start?status=4&selectedView=0&displayType=3'] span");
        private By modalMetKVs = By.CssSelector("a[ng-href='/start?status=4&key=true&selectedView=0&displayType=3'] strong");

        // Cell tooltip locators
        private By cellTooltip = By.CssSelector(".heatmap-data-cell-tooltip");
        private By tooltipHeader = By.CssSelector(".heatmap-data-cell-tooltip .header");

        public void ClickOnSidemenuButton()
        {
            WaitForPageToLoad(webdriver);
            webdriver.FindElement(sidemenuButton).Click();
        }

        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public string GetBreadcrumbs()
        {
            return GetBreadcrumbsA(webdriver);
        }

        public string GetPageTitle()
        {
            WaitForPageToLoad(webdriver);
            return webdriver.FindElement(pageTitle).Text.Trim();
        }

        public void WriteInFileTotalReqsAndKVsOnPage()
        {
            string requirements = webdriver.FindElement(totalRequirements).Text;
            string kvs = webdriver.FindElement(totalKVs).Text;
            string textToWrite = requirements + Environment.NewLine + kvs;

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\HeatmapModal.txt";
            File.WriteAllText(path, textToWrite);
        }

        public void ClickOnTotalSummaryCell()
        {
            webdriver.FindElement(totalSummaryCell).Click();
        }


        /********** Requirements modal methods ******************************************/
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

        public void ClickOnModalViewReqButton()
        {
            webdriver.FindElement(modalViewReqButton).Click();
        }

        public HeatmapModalModel GetModalInformation()
        {
            HeatmapModalModel model = new HeatmapModalModel();

            model.TotalReqs = webdriver.FindElement(modalTotalReqs).Text;
            model.TotalKVs = webdriver.FindElement(modalTotalKVs).Text;


            string[] notMetReq = webdriver.FindElement(modalNotMetReqs).Text.Split(new[] { "Met" }, StringSplitOptions.None);
            model.ReqNotMet = notMetReq[0].Trim();
            model.ReqNotMetKV = webdriver.FindElement(modalNotMetKVs).Text;

            string[] partialReq = webdriver.FindElement(modalPartialReqs).Text.Split(new[] { "Met" }, StringSplitOptions.None);
            model.ReqPartiallyMet = partialReq[0].Trim();
            model.ReqPartiallyMetKV = webdriver.FindElement(modalPartialKVs).Text;

            string[] metReq = webdriver.FindElement(modalMetReqs).Text.Split(new[] { "Met" }, StringSplitOptions.None);
            model.ReqMet = metReq[0].Trim();
            model.ReqMetKV = webdriver.FindElement(modalMetKVs).Text;

            return model;
        }

        public void ClickOnModalTotalReqsLink()
        {
            webdriver.FindElement(modalTotalReqs).Click();
        }

        public void ClickOnModalTotalKVsLink()
        {
            webdriver.FindElement(modalTotalKVs).Click();
        }
        /************************************************************************/

        /********** Filters methods ******************************************/
        public void ClickOnAgencyDropdown()
        {
            webdriver.FindElement(agencyDropdown).Click();
        }

        public string GetNumberOfAgenciesInDropdown()
        {
            return webdriver.FindElement(agenciesInDropdownList).Text;
        }
        /************************************************************************/





        /********** Heatmap methods ******************************************/
        public void WriteInFileNumberOfAgenciesOnHeatmap()
        {
            List<IWebElement> agenciesList = webdriver.FindElements(agencyCellsList).ToList();
            string number = agenciesList.Count().ToString();

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            File.WriteAllText(path, number);
        }
        /************************************************************************/











        public void GrabCellsColorsData()
        {
            IList<HeatmapCellModel> results = new List<HeatmapCellModel>();

            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[ng-show='heatmap.showSummaries']")));
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(Constants.WAIT_TIME_DEFAULT)).Until(ExpectedConditions.ElementToBeClickable(cellListLocator));
            IList<IWebElement> cellList = webdriver.FindElements(cellListLocator);

            foreach (IWebElement elementNow in cellList)
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

                if (itemData.CalculateVisibleColors() == colorCount)
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

            foreach (IWebElement color in statusAreas)
            {
                var colorRawKey = color.GetAttribute("class");
                var colorRawValue = color.GetAttribute("style");

                var colorKey = colorRawKey.Replace("status-", "");
                var colorValue = colorRawValue
                    .Replace("width: 100%; height: ", "")
                    .Replace("%;", "")
                    .Replace("width: 0px; height: ", "")
                    .Replace("px;", "")
                    .Trim();

                result.colors.Add(colorKey, colorValue);
            }
            result.CalculateVisibleColors();

            return result;
        }



    }
}
