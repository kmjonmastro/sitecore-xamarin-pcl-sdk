﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MobileSdk_IntegrationTest_Desktop.Specs.GetItems
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetPublicKeyTest")]
    public partial class GetPublicKeyTestFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetPublicKeyTest.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetPublicKeyTest", "In order to get data from sitecore securely\r\nAs a daveloper\r\nI want to get public" +
                    " key", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with correct authentication parameters")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithCorrectAuthenticationParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with correct authentication parameters", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have logged in \"authenticatedInstanceURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table1.AddRow(new string[] {
                        "sitecore\\admin",
                        "b"});
#line 9
 testRunner.And("I have choosed user", ((string)(null)), table1, "And ");
#line 12
 testRunner.When("I send request to get item by id \"HomeItemId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("I\'ve got 1 items in response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with invalid instance Url")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithInvalidInstanceUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with invalid instance Url", new string[] {
                        "mytag"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I have logged in \"incorrectInstanceURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table2.AddRow(new string[] {
                        "sitecore\\admin",
                        "b"});
#line 18
 testRunner.And("I have choosed user", ((string)(null)), table2, "And ");
#line 21
 testRunner.When("I try to get an item by id \"HomeItemId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I\'ve got an \"System.Xml.XmlException\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("the error message contains \"Name cannot begin with the \' \' character\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with empty instance Url")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithEmptyInstanceUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with empty instance Url", new string[] {
                        "mytag"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I have logged in empty instance url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("I have tried to connect as admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the error message contains \"Value cannot be null\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with incorrect username and password")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with incorrect username and password", new string[] {
                        "mytag"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I have logged in \"authenticatedInstanceURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table3.AddRow(new string[] {
                        "sitecore\\\nouser",
                        "incorrect"});
#line 34
 testRunner.And("I have choosed user", ((string)(null)), table3, "And ");
#line 37
 testRunner.When("I try to get an item by id \"HomeItemId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("I\'ve got an \"ScAuthenticationError\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("the error message contains \"Cannot connect with specified username and password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with empty password")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithEmptyPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with empty password", new string[] {
                        "mytag"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I have logged in \"authenticatedInstanceURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table4.AddRow(new string[] {
                        "sitecore\\admin",
                        ""});
#line 44
 testRunner.And("I have choosed user", ((string)(null)), table4, "And ");
#line 47
 testRunner.When("I try to get an item by id \"HomeItemId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("I\'ve got an \"ScAuthenticationError\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("the error message contains \"Cannot connect with specified username and password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get item with invalid password")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GetItemWithInvalidPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get item with invalid password", new string[] {
                        "mytag"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
 testRunner.Given("I have logged in \"authenticatedInstanceURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table5.AddRow(new string[] {
                        "tra-ta-ta$#",
                        "pwd^&- + \""});
#line 54
 testRunner.And("I have choosed user", ((string)(null)), table5, "And ");
#line 57
 testRunner.When("I try to get an item by id \"HomeItemId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("I\'ve got an \"ScAuthenticationError\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.And("the error message contains \"Cannot connect with specified username and password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
