using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LoginProcess123.PageObjects
{
    public class YahooLoginPageObjects
    {
        [FindsBy(How = How.XPath, Using = "//*[@id = 'login-container']")]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//*[@name = 'username']")]
        public IWebElement usernameCredentials;

        [FindsBy(How = How.XPath, Using = "//*[@type = 'submit']")]
        public IWebElement nextButton;

        [FindsBy(How = How.XPath, Using = "//*[@type = 'password']")]
        public IWebElement passwordCredentials;
    }
}
