using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LoginProcess123.PageObjects
    {
        public class VoltaLoginPageObjects
        {
            [FindsBy(How = How.XPath, Using = "(//button[@type = 'button'])[1]")]
            public IWebElement loginButton;

            [FindsBy(How = How.XPath, Using = "//*[@id = 'nameOrEmail']")]
            public IWebElement usernameCredentials;

            [FindsBy(How = How.XPath, Using = "//*[@type = 'password']")]
            public IWebElement passwordCredentials;

            [FindsBy(How = How.XPath, Using = "//*[text() = 'Trimite']")]
            public IWebElement sendButton;
        }
    }
   