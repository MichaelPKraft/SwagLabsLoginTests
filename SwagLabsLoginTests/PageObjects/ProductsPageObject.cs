using OpenQA.Selenium;
using SwagLabsLoginTests.PageObjects;

namespace SwagLabsLoginTest.PageObjects
{
    public class ProductsPageObject : BasePageObject
    {
        private const string ProductsPageUrl = "https://www.saucedemo.com/inventory.html";

        public ProductsPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

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