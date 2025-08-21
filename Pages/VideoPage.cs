using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace Youtube_search_auto_appium.Pages
{
    public class VideoPage
    {

        private readonly AndroidDriver _driver;
        private readonly WebDriverWait _wait;


        private By PlayerView => MobileBy.XPath("//android.support.v7.widget.RecyclerView[@resource-id=\"com.google.android.youtube:id/results\"]");
        private By VideoPlay => MobileBy.XPath("(//android.widget.ImageView[@resource-id=\"com.google.android.youtube:id/thumbnail\"])[1]");

        public VideoPage(AndroidDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        public bool IsVideoPlayerDisplayed()
        {
            try
            {
                return _wait.Until(d => d.FindElement(PlayerView)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
