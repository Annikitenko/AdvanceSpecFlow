using AdvanceSpecFlowProject.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace AdvanceSpecFlowProject.Base
{
    public class BasePage
    {
        protected readonly IWebDriver WrappedDriver;
        protected readonly WebDriverWait WrappedWait;
        public BasePage()
        {
            WrappedDriver = Driver.GetBrowser() ?? throw new ArgumentNullException("The wrapped IWebDriver instance is not initialized.");
            WrappedWait = Driver.GetBrowserWait();
        }

        public BasePage(IWebDriver driver)
        {

        }

        private readonly string _url = "https://projectplanappweb-stage.azurewebsites.net/login";

        public void Navigate()
        {
            WrappedDriver.Navigate().GoToUrl(_url);
        }
        public void WaitAndClick(By locator)
        {
            WrappedWait.Until(ExpectedConditions.ElementIsVisible(locator));
            WrappedWait.Until(ExpectedConditions.ElementToBeClickable(WrappedDriver.FindElement(locator))).Click();
        }
        public void WaitAndSendKeys(By locator, string text)
            {
                WrappedWait.Until(ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
            }

        public void Search(string textToType)
        {
            GetSearchBox().Clear();
            GetSearchBox().SendKeys(textToType);
            GetGoButton().Click();
        }
        private IWebElement GetSearchBox()
        {
            return WrappedDriver.FindElement(By.Id("sb_form_q"));
        }
        private IWebElement GetGoButton()
        {
            return WrappedDriver.FindElement(By.Id("sb_form_go"));
        }

    }

}

