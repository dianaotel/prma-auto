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
        private static string objSelector = "rd-froala-editor-inline[title='Objectives'] ";
        private By objSectionTitle = By.CssSelector(objSelector + ".rd-heading");
        private By objTextPanel = By.CssSelector(objSelector + "div[contenteditable='false']");
        private By objEditButton = By.CssSelector(".froala-pencil");
        private By objEditorToolbar = By.CssSelector(objSelector + ".fr-toolbar");
        private By objEditorPanel = By.CssSelector(objSelector + "div[contenteditable='true']");
        private By objSaveButton = By.CssSelector(objSelector + ".save");
        private By objCancelButton = By.CssSelector(objSelector + ".cancel");


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
            return webdriver.FindElement(pageTitle).Text;
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

        public void WriteTextInObjectivesEditor(string text)
        {
            IWebElement editor = webdriver.FindElement(objEditorPanel);
            editor.Clear();
            editor.SendKeys(text);
        }

        public void ClearObjectivesText()
        {
            webdriver.FindElement(objEditorPanel).Clear();
        }

        public void ClickOnObjectivesSaveButton()
        {
            webdriver.FindElement(objSaveButton).Click();
        }

        public void ClickOnObjectivesCancelButton()
        {
            webdriver.FindElement(objCancelButton).Click();
        }

        public bool IsObjTextSaved(string text)
        {
            return webdriver.FindElement(objTextPanel).Text.Equals(text);
        }

    }
}
