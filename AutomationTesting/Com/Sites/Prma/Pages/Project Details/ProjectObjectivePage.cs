using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationTesting.Com.DataModels;
using AutomationTesting.Com.Tools;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTesting.Com.Sites.Prma.Pages.Project_Details
{
    class ProjectObjectivePage : AbstractPage
    {
        private IWebDriver webdriver;

        public ProjectObjectivePage(IWebDriver driver)
        {
            webdriver = driver;
        }

        // Sidemenu locators
        private By projectDetailsButton = By.CssSelector("");
        private By sidemenuButton = By.CssSelector("");

        // Header locators
        private By pageTitle = By.CssSelector(".rd-title");

        // Objectives locators
        private By objSectionTitle = By.CssSelector("rd-froala-editor-inline[title='Objectives'] .rd-heading");
        private By objEditButton = By.CssSelector(".froala-pencil");
        private By objEditorToolbar = By.CssSelector("rd-froala-editor-inline[title='Objectives'] .fr-toolbar");
        private By objEditorPanel = By.CssSelector("rd-froala-editor-inline[title='Objectives'] .fr-wrapper .fr-element");

        public void NavigateToUrl(string url)
        {
            NavigateToUrlA(webdriver, url);
        }

        public string GetCurrentUrl()
        {
            return GetCurrentUrlA(webdriver);
        }

        public string GetPageTitle()
        {
            return webdriver.FindElement(objSectionTitle).Text;
        }

        public void ClickOnObjEditButton()
        {
            webdriver.FindElement(objEditButton).Click();
        }

        public bool IsObjEditorVisible()
        {
            try
            {
                return webdriver.FindElement(objEditorToolbar).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public void WriteTextInObjectivesEditor()
        //{
        //    webdriver.FindElement();
        //}
    }
}
