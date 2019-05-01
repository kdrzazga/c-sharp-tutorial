using SeleniumFramework.Core;
using ToolsQA.TestCases.SeleniumEasy;

namespace ToolsQA.TestCases
{
    class SeleniumEasyTests
    {

        private BootstrapAlertMessagesDemoPage AlertPage;

        public void RunAlertsTests()
        {
            var driver = WebDriverFactory.CreateChromeDriver();

            this.AlertPage = new BootstrapAlertMessagesDemoPage(WebDriverFactory.CreateChromeDriver());

            this.AlertPage.ClickAutoclosableDangerMsgButton();
        }
    }
}
