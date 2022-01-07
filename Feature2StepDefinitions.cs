using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class Feature2StepDefinitions
    {
        [Given(@"\[context]")]
        public void GivenContext()
        {
            throw new PendingStepException();
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
            throw new PendingStepException();
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            throw new PendingStepException();
        }
    }
}
