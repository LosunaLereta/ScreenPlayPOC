using CoreFramework.PageObjects;
using TechTalk.SpecFlow;

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        internal PageObjects PageObjects;

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //No need to do multiple instances
            PageObjects.DashboardInteractions.Method1();
            PageObjects.DashboardInteractions.Method2();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            PageObjects.WindowsInteractions.Method3();
        }

    }
}
