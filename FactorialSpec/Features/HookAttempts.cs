using TechTalk.SpecFlow;
using Factorial;

namespace FactorialSpec.Features
{
    [Binding]
    public sealed class HookAttempts
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        // Trying to get a ScenarioContext object loaded before I run the test
        // This was my first attempt to get everrything working before I discovered my issue
        //[BeforeTestRun]
        //public static void FirstBeforeTest()
        //{
        //    //Console.WriteLine("Hello Pre test world!");
        //    FactorialClass fact = new FactorialClass();
        //}
        

        // After understanding how to get the output I want I looked to reenter it into the HookAttempts file but it lacks the reference to
        // _scenarioContext that I need in order to complete the task

        //[Before]
        //public void FirstBeforeFeature()
        //{
        //    //Console.WriteLine("Hello Pre test world!");
        //    FactorialClass fact = new FactorialClass();
        //    _scenarioContext.Add("factContain", fact);
        //}
    }
}