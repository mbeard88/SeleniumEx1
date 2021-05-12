using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeTestFramework
{
    class AP_HomePage
    {
        public IWebDriver SeleniumDriver { get; }
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signinLink => SeleniumDriver.FindElement(By.LinkText("Sign in"));
        public AP_HomePage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }

        public void VisitSignInPage()
        {
            _signinLink.Click();

        }

        public string GetPageTitle()
        {
            return SeleniumDriver.Title;
        }
        
    }
}
