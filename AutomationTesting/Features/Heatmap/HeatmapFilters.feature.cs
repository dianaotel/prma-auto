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
namespace AutomationTesting.Features.Heatmap
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("HeatmapFilters", Description="\tTesting the heatmap filters\r\n\tOn a project set on detailed view", SourceFile="Features\\Heatmap\\HeatmapFilters.feature", SourceLine=0)]
    public partial class HeatmapFiltersFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HeatmapFilters.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HeatmapFilters", "\tTesting the heatmap filters\r\n\tOn a project set on detailed view", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void _1VerifyThatTheTotalNumberOfAgencyColumnsMatchesTheTotalNumberOfAgenciesInDrop_Down(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(1) Verify that the total number of agency columns matches the total number of ag" +
                    "encies in drop-down", exampleTags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I save the number of agencies on the heatmap in a file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I open the heatmap Filter by Agency drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I check the number of agencies in the drop-down is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(1) Verify that the total number of agency columns matches the total number of ag" +
            "encies in drop-down, ABBV-085 in SCCHN TPP assessment", SourceLine=15)]
        public virtual void _1VerifyThatTheTotalNumberOfAgencyColumnsMatchesTheTotalNumberOfAgenciesInDrop_Down_ABBV_085InSCCHNTPPAssessment()
        {
#line 5
this._1VerifyThatTheTotalNumberOfAgencyColumnsMatchesTheTotalNumberOfAgenciesInDrop_Down("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _2VerifyTheAgencyFilterUncheckFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(2) Verify the Agency filter uncheck functionality", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("I see agency columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("I open the heatmap Filter by Agency drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("I select the Uncheck all option on Agency filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("all agency columns disappear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(2) Verify the Agency filter uncheck functionality, ABBV-085 in SCCHN TPP assessm" +
            "ent", SourceLine=30)]
        public virtual void _2VerifyTheAgencyFilterUncheckFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 19
this._2VerifyTheAgencyFilterUncheckFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _3VerifyTheAgencyFilterCheckAllFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(3) Verify the Agency filter check all functionality", exampleTags);
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("I see agency columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("I open the heatmap Filter by Agency drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("I select the Uncheck all option on Agency filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("I select the Check all option on Agency filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.Then("I see agency columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(3) Verify the Agency filter check all functionality, ABBV-085 in SCCHN TPP asses" +
            "sment", SourceLine=46)]
        public virtual void _3VerifyTheAgencyFilterCheckAllFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 34
this._3VerifyTheAgencyFilterCheckAllFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _4VerifyTheAgenciesDisplayedAreTheOnesSelectedInTheDrop_Down(string project_Title, string agency1, string agency2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(4) Verify the agencies displayed are the ones selected in the drop-down", exampleTags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("I see agency columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("I open the heatmap Filter by Agency drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("I select the Uncheck all option on Agency filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And(string.Format("I select agency1 \'{0}\' and agency2 \'{1}\'", agency1, agency2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Then("I see agency columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And(string.Format("the agencies on the heatmap are agency1 \'{0}\' and agency2 \'{1}\'", agency1, agency2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(4) Verify the agencies displayed are the ones selected in the drop-down, Automat" +
            "ion Project 2", SourceLine=63)]
        public virtual void _4VerifyTheAgenciesDisplayedAreTheOnesSelectedInTheDrop_Down_AutomationProject2()
        {
#line 50
this._4VerifyTheAgenciesDisplayedAreTheOnesSelectedInTheDrop_Down("Automation Project 2", "Infarmed (Portugal)", "NICE_2015 (England)", ((string[])(null)));
#line hidden
        }
        
        public virtual void _5VerifyThatTheTotalNumberOfDomainRowsMatchesTheTotalNumberOfDomainsInDrop_Down(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(5) Verify that the total number of domain rows matches the total number of domai" +
                    "ns in drop-down", exampleTags);
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I save the number of domains on the heatmap in a file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.When("I open the heatmap Filter by Domain drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("I check the number of domains in the drop-down is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(5) Verify that the total number of domain rows matches the total number of domai" +
            "ns in drop-down, ABBV-085 in SCCHN TPP assessment", SourceLine=77)]
        public virtual void _5VerifyThatTheTotalNumberOfDomainRowsMatchesTheTotalNumberOfDomainsInDrop_Down_ABBV_085InSCCHNTPPAssessment()
        {
#line 67
this._5VerifyThatTheTotalNumberOfDomainRowsMatchesTheTotalNumberOfDomainsInDrop_Down("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _6VerifyTheDomainFilterUncheckFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(6) Verify the Domain filter uncheck functionality", exampleTags);
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.Then("I see domain rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("I open the heatmap Filter by Domain drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("I select the Uncheck all option on Domain filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("all domain rows disappear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(6) Verify the Domain filter uncheck functionality, ABBV-085 in SCCHN TPP assessm" +
            "ent", SourceLine=92)]
        public virtual void _6VerifyTheDomainFilterUncheckFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 81
this._6VerifyTheDomainFilterUncheckFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _7VerifyTheDomainFilterCheckAllFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(7) Verify the Domain filter check all functionality", exampleTags);
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 98
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("I see domain rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.When("I open the heatmap Filter by Domain drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.And("I select the Uncheck all option on Domain filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("I select the Check all option on Domain filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.Then("I see domain rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(7) Verify the Domain filter check all functionality, ABBV-085 in SCCHN TPP asses" +
            "sment", SourceLine=108)]
        public virtual void _7VerifyTheDomainFilterCheckAllFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 96
this._7VerifyTheDomainFilterCheckAllFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _8VerifyTheDomainsDisplayedAreTheOnesSelectedInTheDrop_Down(string project_Title, string domain1, string domain2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(8) Verify the domains displayed are the ones selected in the drop-down", exampleTags);
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.Then("I see domain rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.When("I open the heatmap Filter by Domain drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.And("I select the Uncheck all option on Domain filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And(string.Format("I select domain1 \'{0}\' and domain2 \'{1}\'", domain1, domain2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("I see domain rows", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.And(string.Format("the domains on the heatmap are domain1 \'{0}\' and domain2 \'{1}\'", domain1, domain2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(8) Verify the domains displayed are the ones selected in the drop-down, Automati" +
            "on Project 2", SourceLine=125)]
        public virtual void _8VerifyTheDomainsDisplayedAreTheOnesSelectedInTheDrop_Down_AutomationProject2()
        {
#line 112
this._8VerifyTheDomainsDisplayedAreTheOnesSelectedInTheDrop_Down("Automation Project 2", "Trial design", "Costs", ((string[])(null)));
#line hidden
        }
        
        public virtual void _9VerifyTheAllSummariesUncheckFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(9) Verify the All Summaries uncheck functionality", exampleTags);
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.Then("I see the requirement summary section and row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.When("I uncheck the All Summaries checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.Then("the requirement summary section and row dissapear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(9) Verify the All Summaries uncheck functionality, ABBV-085 in SCCHN TPP assessm" +
            "ent", SourceLine=139)]
        public virtual void _9VerifyTheAllSummariesUncheckFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 129
this._9VerifyTheAllSummariesUncheckFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
#line hidden
        }
        
        public virtual void _10VerifyTheAllSummariesCheckFunctionality(string project_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(10) Verify the All Summaries check functionality", exampleTags);
#line 143
this.ScenarioSetup(scenarioInfo);
#line 144
 testRunner.Given("I navigate to the login URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 145
 testRunner.And("I login with valid prma admin credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.When(string.Format("I open the project \'{0}\'", project_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.And("I navigate to the heatmap", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("I uncheck the All Summaries checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.When("I check the All Summaries checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
 testRunner.Then("I see the requirement summary section and row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("(10) Verify the All Summaries check functionality, ABBV-085 in SCCHN TPP assessme" +
            "nt", SourceLine=153)]
        public virtual void _10VerifyTheAllSummariesCheckFunctionality_ABBV_085InSCCHNTPPAssessment()
        {
#line 143
this._10VerifyTheAllSummariesCheckFunctionality("ABBV-085 in SCCHN TPP assessment", ((string[])(null)));
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
