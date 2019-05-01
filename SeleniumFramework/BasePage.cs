using System;
using OpenQA.Selenium;

namespace SeleniumFramework
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo()
        {
            this.driver.Navigate();
        }
    }
}
