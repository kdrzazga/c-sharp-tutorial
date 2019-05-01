using ToolsQA.TestCases;

namespace ToolsQA
{
    class TestRunner
    {
        static void Main(string[] arguments)
        {
            //new FirstTestCase().Run();

            RunSeleniumEasyTests();
        }

        private static void RunSeleniumEasyTests()
        {
           var seleniumEasyTests = new SeleniumEasyTests();

           seleniumEasyTests.RunAlertsTests();
        }
    }
}
