using AdvanceSpecFlowProject.Base;
using OpenQA.Selenium;
using System;

namespace AdvanceSpecFlow.PageObjectModel
{
    public class EmailPage:BasePage
    {
        private By emailField => By.CssSelector("input[name=loginfmt]");
        private By nextButton => (By.XPath("//input[@type='submit']"));
        private By emailMessage => By.XPath("//div[@title = 'automation.pp@amdaris.com']");

        public PasswordPage EnterEmailText(string email)
        {
            WaitAndSendKeys(emailField, email);
            return new PasswordPage();
        }

        public PasswordPage ClickNext()
        {
            WaitAndClick(nextButton);
            return new PasswordPage();
        }
        /*
public void AssertError(string expectedResult)
{
   string actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(emailMessage)).Text;
   Assert.AreEqual(expectedResult, actualResult);
}*/
    }   
}
