using System;

using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    class AP_WebSite
    {
        public IWebDriver SeleniumDriver { get; set; }
        public AP_HomePage AP_HomePage { get; internal set; }
        public AP_SigninPage AP_SigninPage { get; internal set; }

        public AP_WebSite(string driver, int pageLoadSecs = 10, int waitSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driver, pageLoadSecs, waitSecs).Driver;

            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
