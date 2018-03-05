﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationTesting.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("LandingPage", new string[] {
            "hta",
            "landingPage"}, SourceFile="Features\\LandingPage.feature", SourceLine=1)]
    public partial class LandingPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LandingPage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LandingPage", null, ProgrammingLanguage.CSharp, new string[] {
                        "hta",
                        "landingPage"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void _1CheckLandingPageInformation(string title, string project1, string project2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(1) Check landing page information", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("I login with valid client admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.Then(string.Format("I should see the landing page with title \'{0}\'", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.And("I should see project cards", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And(string.Format("the projects displayed are correct \'{0}\' \'{1}\'", project1, project2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(1) Check landing page information, All Projects (2)", SourceLine=12)]
        public virtual void _1CheckLandingPageInformation_AllProjects2()
        {
#line 4
this._1CheckLandingPageInformation("All Projects (2)", "Automation Project 1", "Automation Project 2", ((string[])(null)));
#line hidden
        }
        
        public virtual void _2CheckTheContentsOfAProjectCard(string title, string subtitle, string description, string req_Summary, string req_Met, string req_MetKV, string req_Partial, string req_PartialKV, string req_Not, string req_NotKV, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(2) Check the contents of a project card", exampleTags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.And("I login with valid client admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("I should see project cards", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And(string.Format("the first project card contains \'{0}\', \'{1}\', \'{2}\', \'{3}\', \'{4}\', \'{5}\', \'{6}\', " +
                        "\'{7}\', \'{8}\', \'{9}\'", title, subtitle, description, req_Summary, req_Met, req_MetKV, req_Partial, req_PartialKV, req_Not, req_NotKV), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(2) Check the contents of a project card, Automation Project 1", SourceLine=23)]
        public virtual void _2CheckTheContentsOfAProjectCard_AutomationProject1()
        {
#line 16
this._2CheckTheContentsOfAProjectCard("Automation Project 1", "for Automation Disease1", "DO NOT DELETE.", "Requirement Summary: (1 key of 2 requirements)", "1", "0", "0", "0", "1", "1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
