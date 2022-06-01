using AdvanceSpecFlowProject.Base;
using OpenQA.Selenium;

namespace AdvanceSpecFlow.PageObjectModel
{
        public class StaySignedInPage:BasePage
        {
        private By staySignedIn => By.XPath("//div[contains(text(), 'Stay signed in?')]");
        private By dontShowAgainCheck => By.CssSelector("input[name=DontShowAgain]");

        public DashboardPage ClickDontShowAgainAndSubmit()
        {
            WaitAndClick(staySignedIn);
            WaitAndClick(dontShowAgainCheck);
            return new DashboardPage();
        }

        
    /*
        public void AssertError(string expectedResult)
        {
            (ExpectedConditions.UrlToBe(expectedResult));

            string actualUrl = _driver.Url;
            Assert.IsTrue(actualUrl == expectedResult, "Login is not succesful");

        }*/
    }
}
