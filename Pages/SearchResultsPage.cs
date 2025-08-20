using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Youtube_search_auto_appium.Pages
{
    public class SearchResultsPage
    {

        private readonly AndroidDriver _driver;
        private readonly WebDriverWait _wait;

        // Định vị danh sách các video
        private By VideoResults => MobileBy.Id("com.google.android.youtube:id/results");
        private By FirstVideoTitle => MobileBy.XPath("//android.view.ViewGroup[@content-desc=\"Playlist - Appium with C# - Execute Automation - 7 videos\"]/android.view.ViewGroup[1]/android.view.ViewGroup[3]/android.widget.ImageView[1]");

        private By PlayVideo => MobileBy.XPath("(//android.widget.ImageView[@resource-id=\"com.google.android.youtube:id/thumbnail\"])[1]");
        

        public SearchResultsPage(AndroidDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        // Hành động: nhấn vào video đầu tiên
        public VideoPage SelectFirstVideo()
        {
            // Chờ cho danh sách kết quả xuất hiện
            _wait.Until(d => d.FindElement(VideoResults));

            // Lấy và nhấn vào tiêu đề video đầu tiên
            var firstVideo = _driver.FindElement(FirstVideoTitle);
            firstVideo.Click();

            var playButton = _wait.Until(d => d.FindElement(PlayVideo));
            playButton.Click();

            return new VideoPage(_driver);
        }
    }
}
