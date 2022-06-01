using AdvanceSpecFlow.PageObjectModel;
using TechTalk.SpecFlow;

namespace AdvanceSpecFlowProject.Base
{
    [Binding]
    public class LoginAdvance : Base
    {
        LogInPage loginPage;
        EmailPage emailPage;
        PasswordPage passwordPage;
        StaySignedInPage staySignedInPage;

        [Given(@"I am on Advance Login Page")]

        /* public void GivenIAmOnAdvanceLoginPage()
         {
             loginPage.AssertErrorLogin();
         }
         */
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LogInPage loginPage = new LogInPage();
            loginPage.ClickLoginButton();
        }

        [When(@"I write email")]
        public void WhenIWriteEmail(Table table)
        {
            Table table1 = new Table(new string[] {
                        "Login" });
            table1.AddRow(new string[] {
                        "AUTOMATION.PP@AMDARIS.COM"});
            // StaySignedInPage(AdvanceSpecFlowProject);

        }

        [When(@"I press Next button on email page")]
        public void WhenIPressNextButtonOnEmailPage()
        {
            emailPage.ClickNext();
        }

        [When(@"I write password")]
        public void WhenIWritePassword(Table table)
        {
            Table table1 = new Table(new string[] {
                        "Login" });
            table1.AddRow(new string[] {
                        "10704-observe-MODERN-products-STRAIGHT-69112"});

        }
        [When(@"I press Next button on password page")]
        public void WhenIPressNextButtonOnPasswordPage()
        {
            passwordPage.ClickNext();
        }

        [When(@"I press Next button on question page")]
        public void WhenIPressNextButtonOnQuestionPage()
        {
            staySignedInPage.ClickDontShowAgainAndSubmit();
        }


        [Then(@"I can see header of aplication")]
        public void ThenICanSeeHeaderOfAplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
