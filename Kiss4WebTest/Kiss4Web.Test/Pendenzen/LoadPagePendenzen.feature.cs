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
    [TechTalk.SpecRun.FeatureAttribute("Pendenzen - Load page Pendenzen", Description="\tLoad page Pendenzen", SourceFile="Pendenzen\\LoadPagePendenzen.feature", SourceLine=0)]
    public partial class Pendenzen_LoadPagePendenzenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoadPagePendenzen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Pendenzen - Load page Pendenzen", "\tLoad page Pendenzen", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        "",
                        "Task 20180817-1 autotest",
                        "Task 20180817-1 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK2",
                        "BPS2",
                        "1",
                        "4",
                        "Task 20180817-02",
                        "USR2",
                        "USR1",
                        "BPS2",
                        "LEI2",
                        "2018-01-10 00:00:00.000",
                        "2018-05-10 00:00:00.000",
                        "",
                        "",
                        "Task 20180817-2 autotest",
                        "Task 20180817-2 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK3",
                        "BPS1",
                        "2",
                        "6",
                        "Task 20180817-03",
                        "USR2",
                        "USR1",
                        "BPS2",
                        "LEI4",
                        "2018-01-10 00:00:00.000",
                        "2018-10-10 00:00:00.000",
                        "2018-04-10 00:00:00.000",
                        "",
                        "Task 20180817-3 autotest",
                        "Task 20180817-3 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK4",
                        "BPS2",
                        "2",
                        "4",
                        "Task 20180817-04",
                        "USR2",
                        "USR1",
                        "BPS1",
                        "LEI3",
                        "2018-01-10 00:00:00.000",
                        "2018-07-10 00:00:00.000",
                        "2018-06-10 00:00:00.000",
                        "",
                        "Task 20180817-4 autotest",
                        "Task 20180817-4 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK5",
                        "BPS2",
                        "1",
                        "6",
                        "Task 20180817-05",
                        "USR1",
                        "USR2",
                        "BPS1",
                        "LEI1",
                        "2018-01-10 00:00:00.000",
                        "2019-02-10 00:00:00.000",
                        "",
                        "",
                        "Task 20180817-5 autotest",
                        "Task 20180817-5 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK6",
                        "BPS2",
                        "2",
                        "6",
                        "Task 20180817-06",
                        "USR1",
                        "USR2",
                        "BPS1",
                        "LEI1",
                        "2018-01-10 00:00:00.000",
                        "2018-06-10 00:00:00.000",
                        "2018-03-10 00:00:00.000",
                        "",
                        "Task 20180817-6 autotest",
                        "Task 20180817-6 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK7",
                        "BPS2",
                        "2",
                        "2",
                        "Task 20180817-07",
                        "USR1",
                        "USR2",
                        "BPS2",
                        "LEI2",
                        "2018-01-10 00:00:00.000",
                        "2018-09-10 00:00:00.000",
                        "2018-05-10 00:00:00.000",
                        "",
                        "Task 20180817-7 autotest",
                        "Task 20180817-7 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK8",
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
                        "",
                        "Task 20180817-8 autotest",
                        "Task 20180817-8 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK9",
                        "BPS1",
                        "1",
                        "4",
                        "Task 20180817-09",
                        "USR2",
                        "USR1",
                        "BPS2",
                        "LEI4",
                        "2018-01-10 00:00:00.000",
                        "2018-11-10 00:00:00.000",
                        "",
                        "",
                        "Task 20180817-9 autotest",
                        "Task 20180817-9 text",
                        "1",
                        "1"});
            table4.AddRow(new string[] {
                        "TSK10",
                        "BPS2",
                        "1",
                        "2",
                        "Task 20180817-10",
                        "USR2",
                        "USR1",
                        "BPS2",
                        "LEI4",
                        "2018-01-10 00:00:00.000",
                        "2018-12-10 00:00:00.000",
                        "",
                        "",
                        "Task 20180817-10 autotest",
                        "Task 20180817-10 text",
                        "1",
                        "1"});
#line 33
 testRunner.And("these XTask", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01 Get data of tree LeftNavMenu", new string[] {
                "LoadPendenzen"}, SourceLine=46)]
        public virtual void _01GetDataOfTreeLeftNavMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Get data of tree LeftNavMenu", null, new string[] {
                        "LoadPendenzen"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line 48
 testRunner.Given("logon with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.And("go to page Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Meine Pendenzen/fällige",
                        "Meine Pendenzen/offene",
                        "Meine Pendenzen/in Bearbeitung",
                        "Meine Pendenzen/selber erstellte",
                        "Meine Pendenzen/erhaltene",
                        "Meine Pendenzen/zu visierende",
                        "Erstellte Pendenzen/fällige",
                        "Erstellte Pendenzen/offene",
                        "Erstellte Pendenzen/allgemeine",
                        "Erstellte Pendenzen/zu visierende"});
            table5.AddRow(new string[] {
                        "fällige (2)",
                        "offene (7)",
                        "in Bearbeitung (3)",
                        "selber erstellte (1)",
                        "erhaltene (6)",
                        "zu visierende (1)",
                        "fällige (1)",
                        "offene (4)",
                        "allgemeine (3)",
                        "zu visierende (1)"});
#line 50
 testRunner.Then("content of tree LeftNavMenu should be", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02 Get Pendenzen data", new string[] {
                "LoadPendenzen"}, SourceLine=54)]
        public virtual void _02GetPendenzenData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Get Pendenzen data", null, new string[] {
                        "LoadPendenzen"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line 56
 testRunner.Given("logon with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("go to page Pendenzen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Fällig",
                        "Betreff",
                        "Leistung",
                        "Fallträger",
                        "Fallnummer",
                        "Person",
                        "Ersteller",
                        "Empfänger",
                        "Status",
                        "Erfasst",
                        "Bearbeitung",
                        "Erledigt",
                        "Antwort"});
            table6.AddRow(new string[] {
                        "10.01.2020",
                        "Task 20180817-01",
                        "F",
                        "Person test-1, NT (BPS1)",
                        "BPS1",
                        "Person test-1, NT",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "Pendent",
                        "10.01.2018",
                        "NULL",
                        "NULL",
                        "Task 20180817-1 text"});
            table6.AddRow(new string[] {
                        "10.05.2018",
                        "Task 20180817-02",
                        "K",
                        "Person test-1, NT (BPS2)",
                        "BPS2",
                        "Person test-2",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "Pendent",
                        "10.01.2018",
                        "NULL",
                        "NULL",
                        "Task 20180817-2 text"});
            table6.AddRow(new string[] {
                        "10.10.2018",
                        "Task 20180817-03",
                        "F",
                        "Person test-2 (BPS2)",
                        "BPS2",
                        "Person test-1, NT",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "in Bearbeitung",
                        "10.01.2018",
                        "10.04.2018",
                        "NULL",
                        "Task 20180817-3 text"});
            table6.AddRow(new string[] {
                        "10.07.2018",
                        "Task 20180817-04",
                        "K",
                        "Person test-2 (BPS1)",
                        "BPS1",
                        "Person test-2",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "in Bearbeitung",
                        "10.01.2018",
                        "10.06.2018",
                        "NULL",
                        "Task 20180817-4 text"});
            table6.AddRow(new string[] {
                        "10.10.2018",
                        "Task 20180817-08",
                        "K",
                        "Person test-2 (BPS1)",
                        "BPS1",
                        "Person test-1, NT",
                        "test_admin_1 - Global, CMC",
                        "test_admin_1 - Global, CMC",
                        "in Bearbeitung",
                        "10.01.2018",
                        "10.05.2018",
                        "NULL",
                        "Task 20180817-8 text"});
            table6.AddRow(new string[] {
                        "10.11.2018",
                        "Task 20180817-09",
                        "F",
                        "Person test-2 (BPS2)",
                        "BPS2",
                        "Person test-1, NT",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "Pendent",
                        "10.01.2018",
                        "NULL",
                        "NULL",
                        "Task 20180817-9 text"});
            table6.AddRow(new string[] {
                        "10.12.2018",
                        "Task 20180817-10",
                        "F",
                        "Person test-2 (BPS2)",
                        "BPS2",
                        "Person test-2",
                        "test_admin_2 - Soft, CMC",
                        "test_admin_1 - Global, CMC",
                        "Pendent",
                        "10.01.2018",
                        "NULL",
                        "NULL",
                        "Task 20180817-10 text"});
#line 58
 testRunner.Then("data of grid Pendenzen should be", ((string)(null)), table6, "Then ");
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
