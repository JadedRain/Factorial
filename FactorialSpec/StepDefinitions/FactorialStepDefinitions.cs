using System;
using TechTalk.SpecFlow;
using Factorial;
using FactorialSpec.Features;

namespace FactorialSpec.StepDefinitions
{
    [Binding]
    public class FactorialStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        public FactorialStepDefinitions(ScenarioContext sc)
        {
            _scenarioContext = sc;
        }

        // I found out that I can put hooks inside the step definitions file instead of keeping it in a seperate file
        [Before]
        public void BeforeEachScenario()
        {
            //Console.WriteLine("Hello Pre test world!");
            FactorialClass fact = new FactorialClass();
            _scenarioContext.Add("factContain", fact);
        }

        [After]
        public void AfterEachScenario()
        {
            _scenarioContext.Remove("factContain");
        }


        [Given(@"the input of (.*)")]
        public void GivenTheInputOf(int p0)
        {
            FactorialClass f = _scenarioContext.Get<FactorialClass>("factContain");
            f.SetNumber(p0);
            _scenarioContext.Set(f, "factContain");
        }

        [When(@"calculating factorial")]
        public void WhenCalculatingFactorial()
        {
            FactorialClass f = _scenarioContext.Get<FactorialClass>("factContain");
            _scenarioContext.Add("factorial", f.CalculateFactorial());
            _scenarioContext.Set(f, "factContain");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            _scenarioContext.Get<int>("factorial").Should().Be(p0);
        }

    }
}
