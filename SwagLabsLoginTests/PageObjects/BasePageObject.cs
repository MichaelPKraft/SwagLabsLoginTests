using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsLoginTests.PageObjects
{
    public class BasePageObject
    {
        //The Selenium web driver to automate the browser
        protected readonly IWebDriver _webDriver;

        public BasePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
