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
        private By agenciesCheckUncheckAllOption = By.CssSelector(".filter span[items='heatmap.agencies'] .check-uncheck-all");
        private By domainDropdown = By.CssSelector(".filter span[items='heatmap.domains']");
        private By domainsInDropdownList = By.CssSelector(".filter span[items='heatmap.domains'] .items .item");
        private By domainsCheckUncheckAllOption = By.CssSelector(".filter span[items='heatmap.domains'] .check-uncheck-all");
        private By allSummariesCheckbox = By.CssSelector("label[for='show-summaries']");

        // Left-side panel locators
        private By summaryContent = By.CssSelector(".summary-content");
        private By totalDomains = By.CssSelector(".left-side .summary-row:nth-child(1) .value");
        private By totalRequirements = By.CssSelector(".left-side .summary-row:nth-child(2) .value");
        private By totalKVs = By.CssSelector(".left-side .summary-row:nth-child(3) .value");
        private By domainRowsList = By.CssSelector(".domain-row");
        private By domainNameList = By.CssSelector(".domain-cell .name");

        // Cell locators
        private By agencyCellsList = By.CssSelector(".right-container .agency-cell");
        private By totalSummaryCell = By.CssSelector(".total-summary-cell .cell");
        private By cellListLocator = By.CssSelector(".data-cells span.cell");
        private By statusElements = By.CssSelector("div[class*='status']");

        // Domain modal locators
        private By domainModalTitle = By.CssSelector("div[ng-show*='ngDialogData'] .domain-title");
        private By domainModalText = By.CssSelector(".ngdialog-content div[ng-show='ngDialogData.location === null']");

        // Requirements modal locators
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


        /********** Left-side panel methods ******************************************/
        public bool IsSummaryDisplayed()
        {
            try
            {
                return webdriver.FindElement(summaryContent).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
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

        public bool AreDomainRowsDisplayed()
        {
            try
            {
                return webdriver.FindElement(domainRowsList).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void WriteInFileNumberOfDomainsOnHeatmap()
        {
            List<IWebElement> domainsList = webdriver.FindElements(domainRowsList).ToList();
            string number = domainsList.Count().ToString();

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            File.WriteAllText(path, string.Empty);
            File.WriteAllText(path, number);
        }

        public List<string> GetDomainNamesOnHeatmap()
        {
            List<string> domainNames = new List<string>();
            List<IWebElement> domainRows = webdriver.FindElements(domainRowsList).ToList();

            foreach (IWebElement domains in domainRows)
            {
                string name = domains.FindElement(By.CssSelector(".name")).Text;
                domainNames.Add(name);
            }
            return domainNames;
        }

        public void ClickOnDomain(string name)
        {
            List<IWebElement> domainsList = webdriver.FindElements(domainNameList).ToList();
            foreach (IWebElement domain in domainsList)
            {
                if (domain.Text.Equals(name))
                {
                    ClickOnElementJS(webdriver, domain);
                }
            }
            WaitForPageToLoad(webdriver);
        }
        /*****************************************************************************/


        /********** Domain modal methods ******************************************/
        public bool IsDomainModalDisplayed()
        {
            try
            {
                return webdriver.FindElement(domainModalTitle).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public string GetDomainModalTitle()
        {
            return webdriver.FindElement(domainModalTitle).Text;
        }

        public string GetDomainModalText()
        {
            return webdriver.FindElement(domainModalText).Text;
        }
        /*****************************************************************************/


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


        /********** Agency filter methods ******************************************/
        public void ClickOnAgencyDropdown()
        {
            webdriver.FindElement(agencyDropdown).Click();
        }

        public string GetNumberOfAgenciesInDropdown()
        {
            List<IWebElement> agenciesList = webdriver.FindElements(agenciesInDropdownList).ToList();
            return agenciesList.Count().ToString();
        }

        public void ClickOnAgenciesCheckUncheckAllButton()
        {
            webdriver.FindElement(agenciesCheckUncheckAllOption).Click();
        }

        public void ClickOnSpecificAgency(string agency)
        {
            List<IWebElement> agenciesList = webdriver.FindElements(agenciesInDropdownList).ToList();
            foreach (IWebElement ag in agenciesList)
            {
                if (ag.Text.Equals(agency))
                {
                    ag.Click();
                }
            }
        }
        /************************************************************************/


        /********** Domain filter methods ******************************************/
        public void ClickOnDomainDropdown()
        {
            webdriver.FindElement(domainDropdown).Click();
        }

        public string GetNumberOfDomainsInDropdown()
        {
            List<IWebElement> domainsList = webdriver.FindElements(domainsInDropdownList).ToList();
            return domainsList.Count().ToString();
        }

        public void ClickOnDomainsCheckUncheckAllButton()
        {
            webdriver.FindElement(domainsCheckUncheckAllOption).Click();
        }

        public void ClickOnSpecificDomain(string domain)
        {
            List<IWebElement> domainsList = webdriver.FindElements(domainsInDropdownList).ToList();
            foreach (IWebElement dom in domainsList)
            {
                if (dom.Text.Equals(domain))
                {
                    dom.Click();
                }
            }
        }
        /************************************************************************/


        /********** All Summaries filter methods ****************************/
        public void ClickOnAllSummariesCheckbox()
        {
            webdriver.FindElement(allSummariesCheckbox).Click();
        }
        /********************************************************************/

        /********** Heatmap methods ******************************************/
        public bool AreAgencyColumnsDisplayed()
        {
            try
            {
                return webdriver.FindElement(agencyCellsList).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void WriteInFileNumberOfAgenciesOnHeatmap()
        {
            List<IWebElement> agenciesList = webdriver.FindElements(agencyCellsList).ToList();
            string number = agenciesList.Count().ToString();

            string path = @"C:\Users\dianaotel\Desktop\PRMA\Automation\AutomationTesting\AutomationTesting\Com\Tools\Helper files\Heatmap.txt";
            File.WriteAllText(path, string.Empty);
            File.WriteAllText(path, number);
        }

        public List<string> GetAgencyNamesOnHeatmap()
        {
            List<string> agencyNames = new List<string>();
            List<IWebElement> agencyCells = webdriver.FindElements(agencyCellsList).ToList();

            foreach (IWebElement agency in agencyCells)
            {
                string name = agency.FindElement(By.CssSelector("div[ng-attr-title*='shortName']")).Text + " (" + agency.FindElement(By.CssSelector("div[ng-attr-title*='countryName']")).Text + ")";
                agencyNames.Add(name);
            }
            return agencyNames;
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
