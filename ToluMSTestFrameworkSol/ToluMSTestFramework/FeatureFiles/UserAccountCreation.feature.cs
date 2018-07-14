﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ToluMSTestFramework.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class UserAccountCreationTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "UserAccountCreation.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserAccountCreation Tests", "User should be able to create an account when all mandatory fields are completed", ProgrammingLanguage.CSharp, new string[] {
                        "SMOKETEST"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "UserAccountCreation Tests")))
            {
                global::ToluMSTestFramework.FeatureFiles.UserAccountCreationTestsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
 #line 6
  testRunner.Given("I am on the account creation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create an account with valid option")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        public virtual void CreateAnAccountWithValidOption()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an account with valid option", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 9
 testRunner.And("I have entered my Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I have entered my Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I have entered my email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I have entered my telephone number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("I select the continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("My account should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("I should be logged into my homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Unsuccesful account creation with missing mandatory fields (Email)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        public virtual void UnsuccesfulAccountCreationWithMissingMandatoryFieldsEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unsuccesful account creation with missing mandatory fields (Email)", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 18
 testRunner.And("I have entered my Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I have entered my Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.But("I have not entered my email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 21
 testRunner.And("I have entered my telephone number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I select the continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("My account should not be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("I should be logged into my homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Unsuccesful account creation with missing mandatory fields (Telephone)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        public virtual void UnsuccesfulAccountCreationWithMissingMandatoryFieldsTelephone()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unsuccesful account creation with missing mandatory fields (Telephone)", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 27
 testRunner.And("I have entered my Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I have entered my Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I have entered my email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.But("I have not entered my telephone number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 31
 testRunner.When("I select the continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("My account should not be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("I should be logged into my homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing(string firstName, string lastname, string emailaddress, string telephonenumber, string pASSWORD, string confirmPassword, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Don\'t create an account if any of the mandatory fields are missing", exampleTags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 36
 testRunner.And(string.Format("I have entered my \"{0}\"", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And(string.Format("I have entered my \"{0}\"", lastname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("I have entered my \"{0}\"", emailaddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And(string.Format("I have entered my \"{0}\"", telephonenumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I select the continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("My account should not be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("I should be logged into my homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "LARRY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "Tolu@HD.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "0123456789")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "dog")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "dog")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant0()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("", "LARRY", "Tolu@HD.com", "0123456789", "dog", "dog", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "OL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "Tolu@Sbc.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "1232324456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "cat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "cat")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant1()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("OL", "", "Tolu@Sbc.com", "1232324456", "cat", "cat", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Phil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "PHILL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "9494847555")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "love")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "love")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant2()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("Phil", "PHILL", "", "9494847555", "love", "love", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "JOHN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "JAMES")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "ToAu@abc.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "hate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "hate")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant3()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("JOHN", "JAMES", "ToAu@abc.com", "", "hate", "hate", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Dave")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "Terry")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "ht@hy.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "0983636")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "juice")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant4()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("Dave", "Terry", "ht@hy.com", "0983636", "", "juice", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "ali")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "Bongo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "jj@jj.cf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "0989899")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "priest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant5()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("ali", "Bongo", "jj@jj.cf", "0989899", "priest", "", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Don\'t create an account if any of the mandatory fields are missing: Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UserAccountCreation Tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SMOKETEST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Lastname", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:emailaddress", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:telephonenumber", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PASSWORD", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ConfirmPassword", "")]
        public virtual void DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing_Variant6()
        {
#line 35
this.DontCreateAnAccountIfAnyOfTheMandatoryFieldsAreMissing("", "", "", "", "", "", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion