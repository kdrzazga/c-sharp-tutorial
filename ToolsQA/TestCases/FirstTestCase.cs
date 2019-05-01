using SeleniumFramework.Core;
using OpenQA.Selenium;

namespace ToolsQA.TestCases
{
    class FirstTestCase
    {
        private IWebDriver driver;

        private IWebElement sidebar;
        private IWebElement sortableListItem;

        private readonly By sidebarLocator = By.Id("sidebar");
        private readonly By sortableListItemLocator = By.XPath("//aside[1]/ul/li[1]");

        public void Run()
        {
            this.driver = WebDriverFactory.CreateChromeDriver();
            this.driver.Url = "http://www.demoqa.com";

            WindowUtils.MaximizeWindow(this.driver);
            FindElements();
                        
            ClickSortable();

            this.driver.Close();
        }

        private void FindElements()
        {
            this.sidebar = LocatorHelper.QuietlyFindElement(driver, sidebarLocator, 10);

            if (sidebar != null)
            {
                this.sortableListItem = LocatorHelper.QuietlyFindElementWithinElement(driver, sortableListItemLocator, this.sidebar, 10);
            }

        }

        private void ClickSortable()
        {
            if(sortableListItem != null)
            {
                sortableListItem.Click();
            }
        }
    }
}
