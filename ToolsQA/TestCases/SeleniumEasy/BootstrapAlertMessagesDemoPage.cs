
using OpenQA.Selenium;
using SeleniumFramework;
using SeleniumFramework.Core;

namespace ToolsQA.TestCases.SeleniumEasy
{
    class BootstrapAlertMessagesDemoPage : BasePage
    {
        private readonly string URL = "https://www.seleniumeasy.com/test/bootstrap-alert-messages-demo.html";

        private By AutoclosableSuccessMsgButtonLocator = By.Id("autoclosable-btn-success");
        private By NormalSuccessMsgButtonLocator = By.Id("normal-btn-success");
        private By AutoclosableWarningMsgButtonLocator = By.Id("autoclosable-btn-warning");
        private By NormalWarningMsgButtonLocator = By.Id("normal-btn-warning");
        private By AutoclosableDangerMsgButtonLocator = By.Id("autoclosable-btn-danger");
        private By NormalDangerMsgButtonLocator = By.Id("normal-btn-danger");
        private By AutoclosableInfoMsgButtonLocator = By.Id("autoclosable-btn-info");
        private By NormalInfoMsgButtonLocator = By.Id("normal-btn-info");

        private IWebElement AutoclosableSuccessMsgButton;
        private IWebElement NormalSuccessMsgButton;
        private IWebElement AutoclosableWarningMsgButton;
        private IWebElement NormalWarningMsgButton;
        private IWebElement AutoclosableDangerMsgButton;
        private IWebElement NormalDangerMsgButton;
        private IWebElement AutoclosableInfoMsgButton;
        private IWebElement NormalInfoMsgButton;

        public BootstrapAlertMessagesDemoPage(IWebDriver driver) : base(driver){
            this.driver.Url = URL;
        }

        private void FindElements(IWebDriver driver)
        {
            AutoclosableSuccessMsgButton = LocatorHelper.QuietlyFindElement(driver, AutoclosableSuccessMsgButtonLocator, 10);
            NormalSuccessMsgButton = LocatorHelper.QuietlyFindElement(driver, NormalSuccessMsgButtonLocator, 10);
            AutoclosableWarningMsgButton = LocatorHelper.QuietlyFindElement(driver, AutoclosableWarningMsgButtonLocator, 10);
            NormalWarningMsgButton = LocatorHelper.QuietlyFindElement(driver, NormalWarningMsgButtonLocator, 10);
            AutoclosableDangerMsgButton = LocatorHelper.QuietlyFindElement(driver, AutoclosableDangerMsgButtonLocator, 10);
            NormalDangerMsgButton = LocatorHelper.QuietlyFindElement(driver, NormalDangerMsgButtonLocator, 10);
            AutoclosableInfoMsgButton = LocatorHelper.QuietlyFindElement(driver, AutoclosableInfoMsgButtonLocator, 10);
            NormalInfoMsgButton = LocatorHelper.QuietlyFindElement(driver, NormalInfoMsgButtonLocator, 10);
        }

        public void ClickAutoclosableSuccessMsgButton()
        {
            AutoclosableSuccessMsgButton.Click();
        }

        public void ClickNormalSuccessMsgButton()
        {
            NormalSuccessMsgButton.Click();
        }

        public void ClickAutoclosableWarningMsgButton()
        {
            AutoclosableWarningMsgButton.Click();
        }

        public void ClickNormalWarningMsgButton()
        {
            NormalWarningMsgButton.Click();
        }

        public void ClickAutoclosableDangerMsgButton()
        {
            AutoclosableDangerMsgButton.Click();
        }

        public void ClickNormalDangerMsgButton()
        {
            NormalDangerMsgButton.Click();
        }

        public void ClickAutoclosableInfoMsgButton()
        {
            AutoclosableInfoMsgButton.Click();
        }

        public void ClickNormalInfoMsgButton()
        {
            NormalInfoMsgButton.Click();
        }

    }
}
