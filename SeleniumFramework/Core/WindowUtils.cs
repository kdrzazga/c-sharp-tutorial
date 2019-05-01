using OpenQA.Selenium;
using System.Drawing;

namespace SeleniumFramework.Core
{
    public class WindowUtils
    {
        public static void SwitchWindow(IWebDriver driver, string url, bool switchToGivenURL)
        {
            foreach (var winHandle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(winHandle);
                string currentURL = driver.Url;
                        
                bool isSwitchedToGivenURL = currentURL.Contains(url);
                if (isSwitchedToGivenURL == switchToGivenURL)
                {
                    return;
                }
            }
        }

        public static void MaximizeWindow(IWebDriver driver)
        {
            var screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            var screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;

            driver.Manage().Window.Position = new Point(0, 0);
            driver.Manage().Window.Size = new Size((int)screenWidth, (int)screenHeight);
        }

        public static void ScrollPageDown(IWebDriver driver, int scrollValue)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0, " + scrollValue + ")", "");
        }

        public static void ScrollPageUp(IWebDriver driver, int scrollValue)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0, -" + scrollValue + ")", "");
        }

    }
}
