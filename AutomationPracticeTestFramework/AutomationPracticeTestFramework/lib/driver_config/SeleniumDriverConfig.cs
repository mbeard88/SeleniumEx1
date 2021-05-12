using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace AutomationPracticeTestFramework
{
    class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }
        public SeleniumDriverConfig(string driver, int pageLoadSecs, int waitSecs)
        {
            SetChromeDriver();
            SetDriverConfiguration(pageLoadSecs, waitSecs);
        }

        public void DriverSetup(string driver, int pageLoadSecs, int waitSecs)
        {
            if(driver.ToLower() == "chrome")
            {
                SetChromeDriver();
            } else if (driver.ToLower() == "firefox")
            {
                SetFirefoxDriver();
            } else 
            {
                throw new Exception("Please use 'Chrome' or 'Firefox' as a driver argument");
            }
            SetDriverConfiguration(pageLoadSecs, waitSecs);
        }

   

        public void SetDriverConfiguration(int pageLoadSecs, int waitSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitSecs);
        }
        public void SetChromeDriver()
        {
            Driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            // options.AddArgument("headless");
        }

        private void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
            FirefoxOptions options = new FirefoxOptions();
            // options.AddArgument("headless");
        }
    }
}
