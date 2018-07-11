using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ToluMSTestFramework.StepDefinitions
{
    [Binding]
    public sealed class UserAccountCreation
    {
        [Given(@"I am on the account creation page")]
        public void GivenIAmOnTheAccountCreationPage()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"I have entered my Firstname")]
        public void GivenIHaveEnteredMyFirstname()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
