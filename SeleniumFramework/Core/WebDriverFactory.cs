using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Core
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateChromeDriver()
        {
            /*ChromeOptions options = new ChromeOptions();
            options.AddArguments("test-type");
            */
            return new ChromeDriver(@"C:\Users\kdrzazga\webdriver\");
        }
    }
}
