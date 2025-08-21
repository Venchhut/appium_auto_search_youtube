using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SeleniumExtras.WaitHelpers;
using System;

namespace Youtube_search_auto_appium.Pages
{
    public class SearchResultsPage
    {
        private readonly AndroidDriver _driver;
        private readonly WebDriverWait _wait;

        private By PlaylistVideo => MobileBy.XPath(
            "//android.view.ViewGroup[@content-desc=\"Playlist - Appium with C# - Execute Automation - 7 videos\"]/android.widget.ImageView[1]"
        );

        private By FirstThumbnail => MobileBy.XPath(
            "(//android.widget.ImageView[@resource-id=\"com.google.android.youtube:id/thumbnail\"])[1]"
        );

        private By FirstVideoPlay => MobileBy.XPath("(//android.widget.ImageView[@resource-id=\"com.google.android.youtube:id/thumbnail\"])[1]");

        public SearchResultsPage(AndroidDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        public VideoPage SelectFirstVideo()
        {
            IWebElement elementToClick;

            try
            {
                elementToClick = _wait.Until(
                    ExpectedConditions.ElementToBeClickable(PlaylistVideo)
                );

                var firstVideoInPlaylist = _wait.Until(
                    ExpectedConditions.ElementToBeClickable(PlaylistVideo)
                );

                
            }
            catch (WebDriverTimeoutException)
            {
                elementToClick = _wait.Until(
                    ExpectedConditions.ElementToBeClickable(FirstThumbnail)
                );
            }

            elementToClick.Click();
         
            _wait.Until(
                ExpectedConditions.ElementToBeClickable(FirstVideoPlay)
            );
            
            _driver.FindElement(FirstVideoPlay).Click();
            
            return new VideoPage(_driver);
        }
    }
}
