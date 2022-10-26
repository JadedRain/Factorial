using System;
using TechTalk.SpecFlow;
using Factorial;
using FactorialSpec.Features;

namespace FactorialSpec.StepDefinitions
{
    [Binding]
    public class FactorialStepDefinitions
    {
        public FactorialStepDefinitions()
        {

        }
        [Given(@"the input of (.*)")]
        public void GivenTheInputOf(int p0)
        {
            FactorialClass f = _scenarioContext;
        }

        [When(@"calculating factorial")]
        public void WhenCalculatingFactorial()
        {
            throw new PendingStepException();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            throw new PendingStepException();
        }
    }
}
