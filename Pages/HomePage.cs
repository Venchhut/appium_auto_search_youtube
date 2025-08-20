using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace Youtube_search_auto_appium.Pages
{
    public class HomePage
    {
        private readonly AndroidDriver _driver;
        private readonly WebDriverWait _wait;

        // Định vị phần tử
        private By SearchIcon => MobileBy.XPath("//android.widget.ImageView[@content-desc=\"Search\"]");

        private By SearchInput => MobileBy.XPath("//android.widget.EditText[@resource-id=\"com.google.android.youtube:id/search_edit_text\"]");

        public HomePage(AndroidDriver driver) 
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        public SearchResultsPage SearchFor(string searchTerm)
        {
            _wait.Until(d => d.FindElement(SearchIcon)).Click();

            var searchBox = _wait.Until(d => d.FindElement(SearchInput));
            searchBox.SendKeys(searchTerm);
            _driver.PressKeyCode(AndroidKeyCode.Enter);

            return new SearchResultsPage(_driver);
        }
    }
}
