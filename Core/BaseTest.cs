using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;


namespace Youtube_search_auto_appium.Core
{
    public class BaseTest
    {

        protected AndroidDriver _driver;

        [SetUp]
        public void GlobalSetup()
        {
            try {
                var appiumOptions = new AppiumOptions();
                appiumOptions.PlatformName = "Android";
                appiumOptions.DeviceName = "HUCE01";
                appiumOptions.PlatformVersion = "13";
                appiumOptions.AutomationName = "UiAutomator2";

                appiumOptions.AddAdditionalAppiumOption("appPackage", "com.google.android.youtube");
                appiumOptions.AddAdditionalAppiumOption("appActivity", "com.google.android.youtube.app.honeycomb.Shell$HomeActivity");

                //appiumOptions.AddAdditionalAppiumOption("Reset", false);

                _driver = new AndroidDriver(new Uri("http://127.0.0.1:4723"), appiumOptions);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GlobalSetup: " + ex.Message);
            }
        }

        [TearDown]
        public void GlobalTeardown()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}
