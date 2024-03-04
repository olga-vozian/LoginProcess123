using LoginProcess123.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using TechTalk.SpecFlow;
namespace LoginProcess123.Steps
{
    [Binding]
    public class LoginStepsDefinitions
    {
        private IWebDriver driver;
        private VoltaLoginPageObjects voltaLoginPageObjects;
        private SupratenLoginPageObjects supratenLoginPageObjects;
        private YahooLoginPageObjects yahooLoginPageObjects;

        public LoginStepsDefinitions()
        {
            driver = Hooks.Hooks.GetWebDriverInstance();
            voltaLoginPageObjects = Hooks.Hooks.GetVoltaLoginPageObjectsInstance();
            supratenLoginPageObjects = Hooks.Hooks.GetSupratenLoginPageObjectsInstance();
            yahooLoginPageObjects = Hooks.Hooks.GetYahooLoginPageObjectsInstance();
            // Inițializează obiectele PageObjects folosind WebDriver-ul

            PageFactory.InitElements(driver, voltaLoginPageObjects);
            PageFactory.InitElements(driver, supratenLoginPageObjects);
            PageFactory.InitElements(driver, yahooLoginPageObjects);
        }


        [Given(@"the user navigate to login page of ""(.*)""")]
        public void GivenTheUserNavigateToLoginPage(string companyName)
        {
            if (companyName == "Volta")
            {
                driver.Navigate().GoToUrl("https://volta.md/");
            }
            else if (companyName == "Supraten")
            {
                driver.Navigate().GoToUrl("https://supraten.md/");
            }
            else if (companyName == "Yahoo")
            {
                driver.Navigate().GoToUrl("https://yahoo.com/");
            }
        }

        [Given(@"user clicks on ""(.*)""")]
        public void GivenUserClicksOnLoginButton(string companyLoginButton)
        {
            if (companyLoginButton == "VoltaLoginButton")
            {
                voltaLoginPageObjects.loginButton.Click();
            }
            else if (companyLoginButton == "SupratenLoginButton")
            {
                supratenLoginPageObjects.loginButton.Click();
            }
            else if (companyLoginButton == "YahooLoginButton")
            {
                yahooLoginPageObjects.loginButton.Click();
            }
        }

        [When(@"user finds ""(.*)"" and inputs ""(.*)""")]
        public void WhenUserFindsCompanyUserNameFieldAndInputsUserNameCredentials(string companyUserNameField, string usernameCredentials)
        {
            if (companyUserNameField == "VoltaUserNameField")
            {
                voltaLoginPageObjects.usernameCredentials.SendKeys(usernameCredentials);
            }
            else if (companyUserNameField == "SupratenUserNameField")
            {
                supratenLoginPageObjects.cancelButton.Click();
                supratenLoginPageObjects.usernameCredentials.SendKeys(usernameCredentials);
            }
            else if (companyUserNameField == "YahooUserNameField")
            {
                yahooLoginPageObjects.usernameCredentials.SendKeys(usernameCredentials);
            }
        }


        [When(@"user finds ""(.*)"" field and inputs ""(.*)""")]
        public void WhenUserFindCompanyPasswordFieldAndInputsPasswordCredentials(string companyPassword, string passwordCredentials)
        {
            if (companyPassword == "VoltaPassword")
            {
                voltaLoginPageObjects.passwordCredentials.SendKeys(passwordCredentials);
            }
            else if (companyPassword == "SupratenPassword")
            {
                supratenLoginPageObjects.passwordCredentials.SendKeys(passwordCredentials);
            }

            else if (companyPassword == "YahooPassword")
            {
                yahooLoginPageObjects.passwordCredentials.SendKeys(passwordCredentials);
            }
        }

        [Then(@"user finds and clicks on ""(.*)""")]
        public void ThenUserFindAndClickSendButton(string elementName)
        {
            IWebElement element = null;
            switch (elementName)
            {
                case "VoltaSentButton":
                    voltaLoginPageObjects.sendButton.Click();
                    break;
                case "SupratenSentButton":
                    //supratenLoginPageObjects.cancelButton.Click();
                    supratenLoginPageObjects.sendButton.Click();
                    break;
                case "YahooNextButton":
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    yahooLoginPageObjects.nextButton.Click();
                    break;
                // Alte cazuri pentru alte butoane, dacă este necesar
                default:

                    throw new ArgumentException($"Elementul '{elementName}' nu este suportat.");
            }

        }

    }
}

