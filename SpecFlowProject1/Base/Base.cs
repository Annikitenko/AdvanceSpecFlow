using AdvanceSpecFlowProject.Drivers;
using TechTalk.SpecFlow;

namespace AdvanceSpecFlowProject.Base
{
    [Binding]
    public class Base
    {
        [BeforeScenario]
        public static void Setup() 
        {
            Driver.StartBrowser();
        }
        [AfterScenario]
        public void RunAfterScenario()
        {
            Driver.StopBrowser();
        }
    }
}
