using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace LoginProcess123.PageObjects
{
    public class SupratenLoginPageObjects
    {
        [FindsBy(How = How.XPath, Using = "//*[@class = 'sp-header-icons__item sp-header-icons__item_user js-hover']")]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//*[@name = 'email']")]
        public IWebElement usernameCredentials;

        [FindsBy(How = How.XPath, Using = "//*[@name = 'password']")]
        public IWebElement passwordCredentials;

        [FindsBy(How = How.XPath, Using = "//*[@class = 'js-cookies-cancel sp-button sp-button--medium sp-button--red']")]
        public IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//*[@type = 'submit']")]
        public IWebElement sendButton;
    }
}