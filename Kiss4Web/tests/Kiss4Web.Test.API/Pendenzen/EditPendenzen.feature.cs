// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.GeneratedTests.Pendenzen
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EditPendenzenFeature : Xunit.IClassFixture<EditPendenzenFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "EditPendenzen.feature"
#line hidden
        
        public EditPendenzenFeature(EditPendenzenFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EditPendenzen", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 2
 #line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
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
            table6.AddRow(new string[] {
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
            table6.AddRow(new string[] {
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
                        "257000"});
#line 3
 testRunner.Given("these XUser", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "BaPersonID",
                        "Name",
                        "Vorname"});
            table7.AddRow(new string[] {
                        "BPS1",
                        "Person-1",
                        "NT"});
            table7.AddRow(new string[] {
                        "BPS2",
                        "Person 2",
                        "NULL"});
#line 8
 testRunner.And("these BaPerson", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
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
            table8.AddRow(new string[] {
                        "LEI1",
                        "BPS1",
                        "BPS1",
                        "3",
                        "USR1",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-01-10 00:00:00.000"});
            table8.AddRow(new string[] {
                        "LEI2",
                        "BPS1",
                        "BPS2",
                        "21",
                        "USR1",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-02-10 00:00:00.000"});
            table8.AddRow(new string[] {
                        "LEI3",
                        "BPS2",
                        "BPS1",
                        "21",
                        "USR2",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-03-10 00:00:00.000"});
            table8.AddRow(new string[] {
                        "LEI4",
                        "BPS2",
                        "BPS2",
                        "3",
                        "USR2",
                        "0",
                        "0",
                        "1",
                        "0",
                        "2018-04-10 00:00:00.000"});
#line 18
 testRunner.And("these FaLeistung", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
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
            table9.AddRow(new string[] {
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
                        "2"});
#line 25
 testRunner.And("these XTask", ((string)(null)), table9, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="01 Update Pendenzen")]
        [Xunit.TraitAttribute("FeatureTitle", "EditPendenzen")]
        [Xunit.TraitAttribute("Description", "01 Update Pendenzen")]
        [Xunit.TraitAttribute("Category", "servicetest")]
        public virtual void _01UpdatePendenzen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Update Pendenzen", new string[] {
                        "servicetest"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 2
 this.FeatureBackground();
#line 31
 testRunner.Given("init client with username is \'test_admin_1\', password is \'123456\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "status",
                        "pendenzTyp",
                        "betreff",
                        "beschreibung",
                        "empfangerId",
                        "falltrager",
                        "leistung",
                        "PersonId",
                        "antwort",
                        "fallig"});
            table10.AddRow(new string[] {
                        "TSK1",
                        "1",
                        "4",
                        "Update 20180817-01",
                        "Update 20180817-1 autotest",
                        "USR2",
                        "BPS1",
                        "LEI3",
                        "BPS2",
                        "Update 20180817-1 text",
                        "2019-01-10 00:00:00.000"});
#line 32
 testRunner.When("call API CreateUpdateTask in EditPendenzen with input data as below", ((string)(null)), table10, "When ");
#line 35
 testRunner.Then("the call is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And("the return value of API CreateUpdateTask should be true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("the record of the inputted info is updated into table XTask in database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EditPendenzenFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EditPendenzenFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
