using LoginProcess123.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LoginProcess123.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver driver;
        private static VoltaLoginPageObjects voltaLoginPageObjects;
        private static SupratenLoginPageObjects supratenLoginPageObjects;
        private static YahooLoginPageObjects yahooLoginPageObjects;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Initialize Chrome WebDriver
            driver = new ChromeDriver(@"C:\Users\ovozian\source\repos\LoginProcess123\Drivers\");
            driver.Manage().Window.Maximize();

            // Initialize VoltaLoginPageObjects
            voltaLoginPageObjects = new VoltaLoginPageObjects();
            supratenLoginPageObjects = new SupratenLoginPageObjects();
            yahooLoginPageObjects = new YahooLoginPageObjects();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Clean up WebDriver session
            driver.Quit();
        }

        public static IWebDriver GetWebDriverInstance()
        {
            return driver;
        }

        public static VoltaLoginPageObjects GetVoltaLoginPageObjectsInstance()
        {
            return voltaLoginPageObjects;
        }

        public static SupratenLoginPageObjects GetSupratenLoginPageObjectsInstance()
        {
            return supratenLoginPageObjects;
        }

        public static YahooLoginPageObjects GetYahooLoginPageObjectsInstance()
        {
            return yahooLoginPageObjects;
        }
    }
}
