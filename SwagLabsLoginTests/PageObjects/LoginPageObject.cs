using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabsLoginTests.PageObjects;

namespace SwagLabsLoginTest.PageObjects
{
    /// <summary>
    /// Swag Labs Login Page Object
    /// </summary>
    public class LoginPageObject : BasePageObject
    {
        private const string SwagLabsLoginUrl = "https://www.saucedemo.com/";

        public LoginPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        //Find elements
        private IWebElement LoginLogo => _webDriver.FindElement(By.ClassName("login_logo"));
        private IWebElement UserNameElement => _webDriver.FindElement(By.Id("user-name"));
        private IWebElement PasswordElement => _webDriver.FindElement(By.Id("password"));
        private IWebElement LoginButtonElement => _webDriver.FindElement(By.Id("login-button"));

        private IWebElement ErrorTextElement => _webDriver.FindElement(By.XPath("//*[@data-test='error']"));

        public bool LoginPageDisplayed()
        {
            return LoginLogo.Displayed;
        }

        public void EnterUserName(string userName)
        {
            UserNameElement.Clear();
            UserNameElement.SendKeys(userName);
        }

        public void EnterPassword(string password)
        {
            PasswordElement.Clear();
            PasswordElement.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButtonElement.Click();
        }

        public string CheckForLoginError()
        {
            return ErrorTextElement.Text;
        }

        public void EnsureLoginPageIsOpen()
        {
            //Open the Swag Labs page in the browser if not opened yet
            if (_webDriver.Url != SwagLabsLoginUrl)
            {
                _webDriver.Url = SwagLabsLoginUrl;
            }
            else
            {
                _webDriver.Close();
                _webDriver.Url = SwagLabsLoginUrl;
            }
        }
    }
}