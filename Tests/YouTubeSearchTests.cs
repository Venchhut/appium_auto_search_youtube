using Youtube_search_auto_appium.Core;
using Youtube_search_auto_appium.Pages;

namespace Youtube_search_auto_appium.Tests
{
    class YouTubeSearchTests : BaseTest
    {
        [Test]

        public void SearchAndPlayFirstVideo_ShouldSucceed()
        {
            var homePage = new HomePage(_driver);

            var searchResultsPage = homePage.SearchFor("Appium C# tutorial");


            var videoPage = searchResultsPage.SelectFirstVideo();


            Assert.IsTrue(videoPage.IsVideoPlayerDisplayed(), "Trình phát video đã không được hiển thị sau khi click.");
        }
    }
}