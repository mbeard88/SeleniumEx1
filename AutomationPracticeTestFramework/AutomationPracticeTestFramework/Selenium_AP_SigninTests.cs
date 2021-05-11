using System;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPracticeTestFramework
{
    public class Selenium_AP_SigninTests
    {

        [Test()]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://automationpractice.com/");

                IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));

                signinLink.Click();
                Thread.Sleep(1000);

                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
            }

        }
        [TestCase("blahblah")]
        [TestCase("four")]
        public void GivenIAmOnTheSignInPage_AndIEnterA4DigitPassword_WhenIClickTheSigninButton_ThenIGetAnErrorMessage(string p)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");

                IWebElement emailField = driver.FindElement(By.Id("email"));

                emailField.SendKeys("testing@naughtymail.com");

                IWebElement passwordField = driver.FindElement(By.Id("passwd"));

                passwordField.SendKeys(p);

                IWebElement signinLink = driver.FindElement(By.Id("SubmitLogin"));

                signinLink.Click();

                Thread.Sleep(1000);

                IWebElement signinMessage = driver.FindElement(By.ClassName("alert"));


                if (p == "four")
                {
                    Assert.That(signinMessage.Text.Contains("Invalid password"));
                }
                else
                {
                    Assert.That(signinMessage.Text.Contains("Authentication failed"));
                }

            }
        }

        [Test()]
        public void GivenHomePage_ClickOnBestSellers_AndMakeSureChiffonDressAppears()
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://automationpractice.com/");

                IWebElement homePageTabs = driver.FindElement(By.ClassName("blockbestsellers"));

                homePageTabs.Click();

                IWebElement productCollection = driver.FindElement(By.LinkText("Printed Chiffon Dress"));

               //var aa= productCollection.Text;
                Assert.AreEqual("Printed Chiffon Dress", productCollection.Text);
            }
        }
    }
}
