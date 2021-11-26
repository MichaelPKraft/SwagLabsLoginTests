using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SwagLabsLoginTest.Drivers;
using NUnit.Framework;
using SwagLabsLoginTest.PageObjects;

namespace SwagLabsLoginTests.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        //Page Objects needed for test
        private readonly LoginPageObject _loginPageObject;
        private readonly ProductsPageObject _productsPageObject;

        public LoginStepDefinitions(BrowserDriver browserDriver)
        {
            _loginPageObject = new LoginPageObject(browserDriver.Current);
            _productsPageObject = new ProductsPageObject(browserDriver.Current);
        }

        [Given(@"I am on the Sauce Demo Login Page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _loginPageObject.EnsureLoginPageIsOpen();
            Assert.IsTrue(_loginPageObject.LoginPageDisplayed(), "The login page is not displayed");
        }

        [When(@"I fill the account information for account StandardUser \(""(.*)"", ""(.*)""\) into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountStandardUserIntoTheUsernameFieldAndThePasswordField(string username, string password)
        {
            LoginUser(username, password);
        }

        [When(@"I click the Login Button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPageObject.ClickLoginButton();
        }

        [Then(@"I am redirected to the Sauce Demo Main Page")]
        public void ThenIAmRedirectedToTheSauceDemoMainPage()
        {
            _productsPageObject.EnsureProductsPageIsLoaded();
        }

        [Then(@"I verify the App Logo exists")]
        public void ThenIVerifyTheAppLogoExists()
        {
            Assert.IsTrue(_productsPageObject.EnsureAppLogoIsDisplayed(), "The App Logo does not exist");
        }

        [When(@"I fill the account information for account LockedOutUser \(""(.*)"", ""(.*)""\) into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountLockedOutUserIntoTheUsernameFieldAndThePasswordField(string username, string password)
        {
            LoginUser(username, password);
        }

        [Then(@"I verify the Error Message contains the text ""(.*)""")]
        public void ThenIVerifyTheErrorMessageContainsTheText(string errorMessage)
        {
            Assert.AreEqual(errorMessage, _loginPageObject.CheckForLoginError());
        }

        private void LoginUser(string username, string password)
        {
            _loginPageObject.EnterUserName(username);
            _loginPageObject.EnterPassword(password);
        }
    }
}
