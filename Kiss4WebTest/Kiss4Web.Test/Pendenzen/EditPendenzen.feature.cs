﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kiss4Web.Test.Pendenzen
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Pendenzen - Edit Pendenzen", Description="\tEdit a task", SourceFile="Pendenzen\\EditPendenzen.feature", SourceLine=0)]
    public partial class Pendenzen_EditPendenzenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EditPendenzen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Pendenzen - Edit Pendenzen", "\tEdit a task", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
 #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserID",
                        "PermissionGroupID",
                        "GrantPermGroupID",
                        "LogonName",
                        "PasswordHash",
                        "FirstName",
                        "LastName",
                        "ShortName",
                        "IsLocked",
                        "IsUserAdmin",
                        "IsUserBIAGAdmin",
                        "IsMandatsTraeger",
                        "GenderCode",
                        "KeinBDEExport",
                        "MigUserFix",
                        "VerID"});
            table1.AddRow(new string[] {
                        "USR1",
                        "9",
                        "9",
                        "test_admin_1",
                        "kR9Y+JkxEwo=",
                        "CMC",
                        "Global",
                        "cg",
                        "0",
                        "1",
                        "1",
                        "0",
                        "1",
                        "0",
                        "0",
                        "257000"});
            table1.AddRow(new string[] {
                        "USR2",
                        "9",
                        "9",
                        "test_admin_2",
                        "kR9Y+JkxEwo=",
                        "CMC",
                        "Soft",
                        "cs",
                        "0",
                        "1",
                        "1",
                        "0",
                        "1",
                        "0",
                        "0",
                        "258000"});
#line 4
 testRunner.Given("these XUser", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "BaPersonID",
                        "Name",
                        "Vorname"});
            table2.AddRow(new string[] {
                        "BPS1",
                        "Person test-1",
                        "NT"});
            table2.AddRow(new string[] {
                        "BPS2",
                        "Person test-2",
                        "NULL"});
#line 9
 testRunner.And("these BaPerson", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FaLeistungID",
                        "BaPersonID",
                        "FaFallID",
                        "ModulID",
                        "UserID",
                        "IkHatUnterstuetzung",
                        "IkIstRentenbezueger",
                        "IkSchuldnerMahnen",
                        "WiederholteSpezifischeErmittlungEAF",
                        "DatumVon"});
            table3.AddRow(new string[] {
                        "LEI1",
                        "BPS1",
                        "BPS1",
                        "2",
                        "USR1",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-01-10 00:00:00.000"});
            table3.AddRow(new string[] {
                        "LEI2",
                        "BPS1",
                        "BPS2",
                        "7",
                        "USR1",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-02-10 00:00:00.000"});
            table3.AddRow(new string[] {
                        "LEI3",
                        "BPS2",
                        "BPS1",
                        "7",
                        "USR2",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-03-10 00:00:00.000"});
            table3.AddRow(new string[] {
                        "LEI4",
                        "BPS2",
                        "BPS2",
                        "2",
                        "USR2",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-04-10 00:00:00.000"});
#line 26
 testRunner.And("these FaLeistung", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "XTaskID",
                        "BaPersonID",
                        "TaskStatusCode",
                        "TaskTypeCode",
                        "Subject",
                        "SenderID",
                        "ReceiverID",
                        "FaFallID",
                        "FaLeistungID",
                        "CreateDate",
                        "ExpirationDate",
                        "StartDate",
                        "DoneDate",
                        "TaskDescription",
                        "ResponseText",
                        "TaskReceiverCode",
                        "TaskSenderCode"});
            table4.AddRow(new string[] {
                        "TSK1",
                        "BPS1",
                        "1",
                        "4",
                        "Task 20180817-01",
                        "USR2",
                        "USR1",
                        "BPS1",
                        "LEI1",
                        "2018-01-10 00:00:00.000",
                        "2020-01-10 00:00:00.000",
                        "",
                        "NULL",
                        "Task 20180817-1 autotest",
                        "Task 20180817-1 text",
                        "1",
                        ""});
            table4.AddRow(new string[] {
                        "TSK2",
                        "BPS1",
                        "2",
                        "4",
                        "Task 20180817-08",
                        "USR1",
                        "USR1",
                        "BPS1",
                        "LEI3",
                        "2018-01-10 00:00:00.000",
                        "2018-10-10 00:00:00.000",
                        "2018-05-10 00:00:00.000",
                        "NULL",
                        "Task 20180817-8 autotest",
                        "Task 20180817-8 text",
                        "1",
                        "1"});
#line 33
 testRunner.And("these XTask", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01 Switch to edit mode of status in Bearbeitung", new string[] {
                "EditPendenzen"}, SourceLine=38)]
        public virtual void _01SwitchToEditModeOfStatusInBearbeitung()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Switch to edit mode of status in Bearbeitung", null, new string[] {
                        "EditPendenzen"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line 40
 testRunner.Given("logon with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.And("go to page Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("choose row 2 on grid Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("click on button Bearbeiten", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("these items are disabled: LeftNavMenu, SearchArea, GridTask", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Status",
                        "Pendenz Typ",
                        "Betreff",
                        "Beschreibung",
                        "Ersteller",
                        "Empfänger",
                        "Fallträger",
                        "Leistung",
                        "Leistungsverantw.",
                        "betrifft Person",
                        "Antwort",
                        "Erfasst",
                        "Fällig"});
            table5.AddRow(new string[] {
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "true",
                        "false",
                        "true",
                        "true",
                        "false",
                        "true",
                        "true"});
#line 45
 testRunner.And("Pendenzen detail area switches to edit mode of status in Bearbeitung", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02 Edit Pendenzen of status in Bearbeitung", new string[] {
                "EditPendenzen"}, SourceLine=50)]
        public virtual void _02EditPendenzenOfStatusInBearbeitung()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Edit Pendenzen of status in Bearbeitung", null, new string[] {
                        "EditPendenzen"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line 52
 testRunner.Given("logon with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.And("go to page Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("choose row 2 on grid Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("click on button Bearbeiten", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.When("choose \'F - Fallführung (10.01.2018 -)\' in dropdown Leistung", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("input \'Update 20180817-8 text\' into textarea Antwort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("click on button Speichern", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Then("these items are enabled: LeftNavMenu, SearchArea, GridTask", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And("Pendenzen detail area switches to view mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Status",
                        "Pendenz Typ",
                        "Betreff",
                        "Beschreibung",
                        "Ersteller",
                        "Empfänger",
                        "Fallträger",
                        "Leistung",
                        "Leistungsverantw.",
                        "betrifft Person",
                        "Antwort",
                        "Erfasst",
                        "Fällig",
                        "Bearbeitung",
                        "Erledigt"});
            table6.AddRow(new string[] {
                        "in Bearbeitung",
                        "Fristablauf",
                        "Task 20180817-08",
                        "Task 20180817-8 autotest",
                        "test_admin_1 - Global, CMC",
                        "test_admin_1 - Global, CMC",
                        "Person test-1, NT (BPS1)",
                        "F - Fallführung (10.01.2018 -)",
                        "test_admin_1 - Global, CMC",
                        "Person test-1, NT",
                        "Update 20180817-8 text",
                        "10.05.2018",
                        "10.10.2018",
                        "NULL",
                        "NULL"});
#line 61
 testRunner.And("content of Pendenzen detail area should be", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("03 Edit Un-Successfully", new string[] {
                "EditPendenzen"}, SourceLine=65)]
        public virtual void _03EditUn_Successfully()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Edit Un-Successfully", null, new string[] {
                        "EditPendenzen"});
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line 67
 testRunner.Given("logon with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("go to page Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("choose row 1 on grid Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("click on button Bearbeiten", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("clear data in textbox Betreff", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.And("click on button Speichern", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("display error message at below of textbox Betreff with content is: \'Das Feld \'Bet" +
                    "reff\' darf nicht leer bleiben ! \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
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
