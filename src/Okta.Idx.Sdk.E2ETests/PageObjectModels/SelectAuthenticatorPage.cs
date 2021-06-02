﻿using Okta.Idx.Sdk.E2ETests.Drivers;
using OpenQA.Selenium;

namespace Okta.Idx.Sdk.E2ETests.PageObjectModels
{
    public class SelectAuthenticatorPage : BasePage
    {
        public override string RelativePageUri => "Manage/SelectAuthenticator";
        public IWebElement PasswordAuthenticator => _webDriver.FindElement(By.XPath("//label[contains(normalize-space(.),\"Password\")]"));
        public IWebElement EmailAuthenticator => _webDriver.FindElement(By.XPath("//label[contains(normalize-space(.),\"Email\")]"));
        public IWebElement PhoneAuthenticator => _webDriver.FindElement(By.XPath("//label[contains(normalize-space(.),\"Phone\")]"));
        public IWebElement SubmitButton => _webDriver.FindElement(By.XPath("//input[@type=\"submit\"]");

        public SelectAuthenticatorPage(WebDriverDriver webDriverDriver, ITestConfig testConfiguration)
            : base(webDriverDriver, testConfiguration)
        {

        }        
    }
}
