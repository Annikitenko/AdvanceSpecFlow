using AdvanceSpecFlowProject.Base;
using OpenQA.Selenium;

namespace AdvanceSpecFlow.PageObjectModel
{
    public class PasswordPage: BasePage
    {
        private By passwordField => By.XPath("//input[@type='password']");
        private By nextButton => By.XPath("//input[@type='submit']");
   
       public StaySignedInPage SendPasswordAndSubmit(string password) 
       { 
            WaitAndSendKeys(passwordField, password);
            WaitAndClick(nextButton);
            return new StaySignedInPage();
        }
        public StaySignedInPage ClickNext()
        {
            WaitAndClick(nextButton);
            return new StaySignedInPage();
        }


        /*public void AssertError(string expectedResult)
        {
            string actualResult = (ExpectedConditions.ElementIsVisible(passwordMessage)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }*/
    }
}
