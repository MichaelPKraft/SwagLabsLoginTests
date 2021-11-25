using OpenQA.Selenium;

namespace SwagLabsLoginTest.PageObjects
{
    public class ProductsPageObject
    {
        private const string ProductsPageUrl = "https://www.saucedemo.com/inventory.html";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        //public const int DefaultWaitInSeconds = 5;

        public ProductsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Find elements
        //private IWebElement AppLogoElement => _webDriver.FindElement(By.XPath("//*[@class='title'][text()='Products']"));
        private IWebElement AppLogoElement => _webDriver.FindElement(By.ClassName("app_logo"));


        public bool EnsureProductsPageIsLoaded()
        {
            if (_webDriver.Url == ProductsPageUrl)
                return true;
            else
                return false;
        }

        public bool EnsureAppLogoIsDisplayed()
        {
            return AppLogoElement.Displayed;
        }
    }
}