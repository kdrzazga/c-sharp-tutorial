using SeleniumFramework.Core;

namespace ToolsQA.TestCases
{
    class SeleniumEasyTests
    {
        public void Run()
        {
            var driver = WebDriverFactory.CreateChromeDriver();
            driver.Url = "http://www.wp.pl";
            throw new System.Exception("Not implemented yet");

        }
    }
}
