using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.Core
{
    public class LocatorHelper
    {
        private const int TIMEOUT = 8;
        private const int POLLING_INTERVAL = TIMEOUT / 5;

        public static IWebElement QuietlyFindElement(IWebDriver driver, By locator, int timeout)
        {
            try
            {
                if (timeout > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                    return wait.Until(drv => drv.FindElement(locator));
                }
                return driver.FindElement(locator);

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Element " + locator.ToString() + " not found on page " + driver.Url + " " + e.Message);
                return null;
            }
        }

        public static IWebElement QuietlyFindElementWithinElement(IWebDriver driver, By locator, IWebElement parent, int timeout)
        {
            try
            {
                IWebElement element = parent.FindElement(locator);
                Console.WriteLine("Found element: " + element.GetType() + " within parent " + parent);
                return element;

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element " + locator.ToString() + " not found on page " + driver.Url);
                return null;
            }
        }

        public static void FocusOnElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
        }

        public static void SendKeys(IWebDriver driver, IWebElement element, String text)
        {
            FocusOnElement(driver, element);
            Actions action = new Actions(driver);
            action.SendKeys(element, text).Perform();
        }
    }
}

