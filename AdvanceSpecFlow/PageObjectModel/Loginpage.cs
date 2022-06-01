using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSpecFlow.PageObjectModel
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private IWebElement logInButton => _driver.FindElement(By.CssSelector("div .button > span"));
        public LoginPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public void ClickLoginButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(logInButton)).Click(); ;
        }

        public void AssertErrorLogin()
        {
            _wait.Until(ExpectedConditions.UrlContains("https://projectplanappweb-stage.azurewebsites.net/login"));
            string actualUrl = _driver.Url;
            StringAssert.Contains("https://projectplanappweb-stage.azurewebsites.net/login", actualUrl, "Login is not succesful");
        }

        public void AssertError()
        {
            _wait.Until(ExpectedConditions.UrlContains("https://login.microsoftonline.com/"));
            string actualUrl = _driver.Url;
            StringAssert.StartsWith("https://login.microsoftonline.com/", actualUrl, "Login is not succesful");
        }

    }

}
