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
    class PasswordPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public PasswordPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By enterPasswordPageButton => By.XPath("//input[@type='password']");
        private IWebElement nextButton => _driver.FindElement(By.XPath("//input[@type='submit']"));
        private By passwordMessage => By.XPath("//div[contains(text(), 'Stay signed in?')]");


        public void WritePassword(string password)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(enterPasswordPageButton)).SendKeys(password);
        }
        public void PressNextButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(nextButton)).Click(); ;
        }

        public void AssertError(string expectedResult)
        {
            string actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(passwordMessage)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
