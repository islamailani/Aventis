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
namespace SpecFlow.GeneratedTests.Ausgabekonti
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "ref:[KiSS4.DB.SqlQuery.Fill][Line:1094-1271]")]
    [Xunit.TraitAttribute("Category", "servicetest")]
    public partial class SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature : Xunit.IClassFixture<SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SozialHilfe_CtlWhSpezialkonto_GetAusgabekonti.feature"
#line hidden
        
        public SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature(SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SozialHilfe_CtlWhSpezialkonto_GetAusgabekonti", null, ProgrammingLanguage.CSharp, new string[] {
                        "ref:[KiSS4.DB.SqlQuery.Fill][Line:1094-1271]",
                        "servicetest"});
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
#line 4
 #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "BaPersonID",
                        "Name",
                        "Vorname",
                        "Geburtsdatum"});
            table1.AddRow(new string[] {
                        "PRS1",
                        "Schmid",
                        "Patrick",
                        "1981-04-04"});
            table1.AddRow(new string[] {
                        "PRS2",
                        "Nguyen",
                        "Kien",
                        "1982-01-01"});
            table1.AddRow(new string[] {
                        "PRS3",
                        "Schmid",
                        "Loan Nora",
                        "2004-12-01"});
#line 5
 testRunner.Given("these Personen", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FaLeistungID",
                        "BaPersonID",
                        "UserID",
                        "ModulID",
                        "FaProzesscode"});
            table2.AddRow(new string[] {
                        "LEI1",
                        "PRS1",
                        "2091",
                        "2",
                        "200"});
            table2.AddRow(new string[] {
                        "LEI2",
                        "PRS1",
                        "2091",
                        "3",
                        "300"});
#line 10
 testRunner.And("these Leistungen", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgFinanzplanID",
                        "FaLeistungID",
                        "BgBewilligungStatusCode",
                        "WhHilfeTypCode",
                        "GeplantVon",
                        "GeplantBis"});
            table3.AddRow(new string[] {
                        "FIP1",
                        "LEI2",
                        "5",
                        "3",
                        "2018-03-01",
                        "2018-04-30"});
            table3.AddRow(new string[] {
                        "FIP2",
                        "LEI2",
                        "1",
                        "3",
                        "2018-05-01",
                        "2018-11-30"});
#line 14
 testRunner.And("these Finanzpläne", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgFinanzplanID",
                        "BaPersonID",
                        "IstUnterstuetzt"});
            table4.AddRow(new string[] {
                        "FIP1",
                        "PRS1",
                        "true"});
            table4.AddRow(new string[] {
                        "FIP1",
                        "PRS2",
                        "true"});
            table4.AddRow(new string[] {
                        "FIP1",
                        "PRS3",
                        "true"});
            table4.AddRow(new string[] {
                        "FIP2",
                        "PRS1",
                        "true"});
            table4.AddRow(new string[] {
                        "FIP2",
                        "PRS2",
                        "true"});
            table4.AddRow(new string[] {
                        "FIP2",
                        "PRS3",
                        "true"});
#line 18
 testRunner.And("these Finanzplanmitglieder", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgBudgetID",
                        "BgFinanzplanID",
                        "Jahr",
                        "Monat",
                        "MasterBudget",
                        "BgBewilligungStatusCode"});
            table5.AddRow(new string[] {
                        "BUD1",
                        "FIP1",
                        "2018",
                        "03",
                        "true",
                        "5"});
            table5.AddRow(new string[] {
                        "BUD2",
                        "FIP1",
                        "2018",
                        "03",
                        "false",
                        "1"});
            table5.AddRow(new string[] {
                        "BUD3",
                        "FIP1",
                        "2018",
                        "04",
                        "false",
                        "1"});
            table5.AddRow(new string[] {
                        "BUD4",
                        "FIP2",
                        "2018",
                        "05",
                        "true",
                        "1"});
#line 26
 testRunner.And("these Budgets", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgSpezkontoID",
                        "FaLeistungID",
                        "BgSpezkontoTypCode",
                        "NameSpezkonto",
                        "BgKostenartID",
                        "BgPositionsartID",
                        "BaPersonID",
                        "DatumVon",
                        "DatumBis",
                        "Bemerkung",
                        "Inaktiv"});
            table6.AddRow(new string[] {
                        "SPZ1",
                        "LEI2",
                        "Ausgabekonti",
                        "Ausgabekonto 1",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-02-01",
                        "2018-02-28",
                        "Test VP1111",
                        "true"});
            table6.AddRow(new string[] {
                        "SPZ2",
                        "LEI2",
                        "Ausgabekonti",
                        "Ausgabekonto 2",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-03-01",
                        "2018-03-31",
                        "Test VP1112",
                        "false"});
            table6.AddRow(new string[] {
                        "SPZ3",
                        "LEI2",
                        "Ausgabekonti",
                        "Ausgabekonto 3",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-03-01",
                        "2018-04-30",
                        "Test VP1113",
                        "false"});
#line 32
 testRunner.And("these Spezialkonti", ((string)(null)), table6, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="G001_Get aktive Ausgabekonti")]
        [Xunit.TraitAttribute("FeatureTitle", "SozialHilfe_CtlWhSpezialkonto_GetAusgabekonti")]
        [Xunit.TraitAttribute("Description", "G001_Get aktive Ausgabekonti")]
        [Xunit.TraitAttribute("Category", "scenarioid:get_ausgabekonti_valid_001")]
        [Xunit.TraitAttribute("Category", "line:1094-1271")]
        [Xunit.TraitAttribute("Category", "servicetest")]
        public virtual void G001_GetAktiveAusgabekonti()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("G001_Get aktive Ausgabekonti", new string[] {
                        "scenarioid:get_ausgabekonti_valid_001",
                        "line:1094-1271",
                        "servicetest"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 4
 this.FeatureBackground();
#line 42
 testRunner.Given("current month is 03.2018", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When("getting Ausgabekonti of Leistung LEI2, [nur aktive] is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("the call should be successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgSpezkontoID",
                        "FaLeistungID",
                        "BgSpezkontoTypCode",
                        "NameSpezkonto",
                        "BgKostenartID",
                        "BaPersonID",
                        "DatumVon",
                        "DatumBis",
                        "Bemerkung",
                        "Inaktiv"});
            table7.AddRow(new string[] {
                        "SPZ2",
                        "LEI2",
                        "1",
                        "Ausgabekonto 2",
                        "10",
                        "PRS1",
                        "2018-03-01",
                        "2018-03-31",
                        "Test VP1112",
                        "false"});
            table7.AddRow(new string[] {
                        "SPZ3",
                        "LEI2",
                        "1",
                        "Ausgabekonto 3",
                        "10",
                        "PRS1",
                        "2018-03-01",
                        "2018-04-30",
                        "Test VP1113",
                        "false"});
#line 45
 testRunner.And("the received Spezialkonti should be", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="G002_Get inaktive Ausgabekonti")]
        [Xunit.TraitAttribute("FeatureTitle", "SozialHilfe_CtlWhSpezialkonto_GetAusgabekonti")]
        [Xunit.TraitAttribute("Description", "G002_Get inaktive Ausgabekonti")]
        [Xunit.TraitAttribute("Category", "scenarioid:get_ausgabekonti_valid_002")]
        [Xunit.TraitAttribute("Category", "line:1094-1271")]
        [Xunit.TraitAttribute("Category", "servicetest")]
        public virtual void G002_GetInaktiveAusgabekonti()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("G002_Get inaktive Ausgabekonti", new string[] {
                        "scenarioid:get_ausgabekonti_valid_002",
                        "line:1094-1271",
                        "servicetest"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 4
 this.FeatureBackground();
#line 54
 testRunner.Given("current month is 03.2018", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
 testRunner.When("getting Ausgabekonti of Leistung LEI2, [nur aktive] is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the call should be successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "BgSpezkontoID",
                        "FaLeistungID",
                        "BgSpezkontoTypCode",
                        "NameSpezkonto",
                        "BgKostenartID",
                        "BgPositionsartID",
                        "BaPersonID",
                        "DatumVon",
                        "DatumBis",
                        "Bemerkung",
                        "Inaktiv"});
            table8.AddRow(new string[] {
                        "SPZ2",
                        "LEI2",
                        "1",
                        "Ausgabekonto 2",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-03-01",
                        "2018-03-31",
                        "Test VP1112",
                        "false"});
            table8.AddRow(new string[] {
                        "SPZ3",
                        "LEI2",
                        "1",
                        "Ausgabekonto 3",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-03-01",
                        "2018-04-30",
                        "Test VP1113",
                        "false"});
            table8.AddRow(new string[] {
                        "SPZ1",
                        "LEI2",
                        "1",
                        "Ausgabekonto 1",
                        "10",
                        "32121",
                        "PRS1",
                        "2018-02-01",
                        "2018-02-28",
                        "Test VP1111",
                        "true"});
#line 57
 testRunner.And("the received Spezialkonti should be", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SozialHilfe_CtlWhSpezialkonto_GetAusgabekontiFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion