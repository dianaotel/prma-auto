using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Tools;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Pages
{
    class LandingPage : AbstractPage
    {
        private IWebDriver webdriver;

        public LandingPage(IWebDriver driver)
        {
            webdriver = driver;
        }

        // page locators
        private By landingPage = By.CssSelector(".landing-page");
        private By pageTitle = By.CssSelector(".page-header .rd-title");

        // project card locators
        private By projectCard = By.CssSelector(".project-card");
        private By projectTitle = By.CssSelector(".project-card-header .title span:nth-child(1)");
        private By projectSubtitle = By.CssSelector(".project-card-header .title span:nth-child(2)");
        private By projectDescription = By.CssSelector(".project-description");
        private By reqSummary = By.CssSelector(".requirement-summary");
        private By reqMet = By.CssSelector(".requirement-body .summary-column:nth-child(1) span:nth-child(1)");
        private By reqPartial = By.CssSelector(".requirement-body .summary-column:nth-child(1) span:nth-child(2)");
        private By reqNotMet = By.CssSelector(".requirement-body .summary-column:nth-child(1) span:nth-child(3)");

        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public async Task<string> GetPageTitle()
        {
            await Task.Delay(6000);
            return webdriver.FindElement(pageTitle).Text.Trim();
        }

        public bool IsProjectCardVisible()
        {
            try
            {
                return webdriver.FindElement(projectCard).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string GetProjectName(int index)
        {
            return webdriver.FindElement(By.CssSelector(".project-card:nth-child(" + index + ") .project-card-header .title .ng-binding:nth-child(1)")).Text;
        }

        public ProjectCardModel GetCardDetails()
        {
            WaitForPageToLoad(webdriver);

            ProjectCardModel model = new ProjectCardModel();
            model.Title = webdriver.FindElement(projectTitle).Text.Trim();
            model.Subtitle = webdriver.FindElement(projectSubtitle).Text.Trim();
            model.Description = webdriver.FindElement(projectDescription).Text.Trim();
            model.RequirementSummary = webdriver.FindElement(reqSummary).Text.Trim();

            string[] reqMetArray = webdriver.FindElement(reqMet).Text.Split(new[] { "Met" }, StringSplitOptions.None);
            model.ReqMet = reqMetArray[0].Trim();
            string[] reqMetKVArray = reqMetArray[1].Trim().Split(new[] { " " }, StringSplitOptions.None);
            model.ReqMetKV = reqMetKVArray[0].Trim();

            string[] reqPartialArray = webdriver.FindElement(reqPartial).Text.Split(new[] { "Partially Met" }, StringSplitOptions.None);
            model.ReqPartiallyMet = reqPartialArray[0].Trim();
            string[] reqPartialKVArray = reqPartialArray[1].Trim().Split(new[] { " " }, StringSplitOptions.None);
            model.ReqPartiallyMetKV = reqPartialKVArray[0].Trim();

            string[] reqNotMetArray = webdriver.FindElement(reqNotMet).Text.Split(new[] { "Not Met" }, StringSplitOptions.None);
            model.ReqNotMet = reqNotMetArray[0].Trim();
            string[] reqNotMetKVArray = reqNotMetArray[1].Trim().Split(new[] { " " }, StringSplitOptions.None);
            model.ReqNotMetKV = reqNotMetKVArray[0].Trim();
            return model;
        }

        public void ClickOnProject(string title)
        {
            //IList<IWebElement> projectCardsList = webdriver.FindElements(projectCard);
            //projectCardsList.Where(card => card.FindElement(projectTitle).Text.Equals(title))
            //                .ToList().ForEach(card => { card.Click(); });

            //WaitForPageToLoad(webdriver);
            WaitUntilElementVisible(webdriver, projectTitle, 30.00);
            
            IList<IWebElement> projectTitlesList = webdriver.FindElements(projectTitle);

            foreach (IWebElement projectTitle in projectTitlesList)
            {
                if (projectTitle.Text.Equals(title))
                {
                    ClickOnElementJS(webdriver, projectTitle);
                    break;
                }
            }

        }
    }
}
