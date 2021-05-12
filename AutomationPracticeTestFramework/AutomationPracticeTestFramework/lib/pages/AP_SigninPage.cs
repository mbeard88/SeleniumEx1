using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeTestFramework
{
    class AP_SigninPage
    {
        public IWebDriver SeleniumDriver { get; }
        public AP_SigninPage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }

       
    }
}
