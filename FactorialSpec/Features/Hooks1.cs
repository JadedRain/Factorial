using TechTalk.SpecFlow;
using Factorial;

namespace FactorialSpec.Features
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        // Trying to get a ScenarioContext object loaded before I run the test
        [BeforeTestRun]
        public void FirstBeforeScenario(ScenarioContext ScenarioContext)
        {
            ScenarioContext _scenarioContext = ScenarioContext;
            FactorialClass fact = new FactorialClass();
            _scenarioContext.Add("container", fact);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}