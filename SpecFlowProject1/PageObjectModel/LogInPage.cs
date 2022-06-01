using OpenQA.Selenium;
using AdvanceSpecFlowProject.Base;


namespace AdvanceSpecFlow.PageObjectModel
{
    public class LogInPage: BasePage
    {
        private By logInButton => By.CssSelector("div .button > span");
        public LogInPage(IWebDriver driver):base(driver)
        {
            
        }
        public LogInPage() : base()
        {

        }
        public EmailPage ClickLoginButton()
        {
            WaitAndClick(logInButton);
            return new EmailPage();
        }
        /*
        public void AssertErrorLogin()
        {
            wait.Until(ExpectedConditions.UrlContains("https://projectplanappweb-stage.azurewebsites.net/login"));
            string actualUrl = _driver.Url;
            StringAssert.Contains("https://projectplanappweb-stage.azurewebsites.net/login", actualUrl, "Login is not succesful");
        }

        public void AssertError()
        {
            _wait.Until(ExpectedConditions.UrlContains("https://login.microsoftonline.com/"));
            string actualUrl = _driver.Url;
            StringAssert.StartsWith("https://login.microsoftonline.com/", actualUrl, "Login is not succesful");
        }
        */
    }

}
