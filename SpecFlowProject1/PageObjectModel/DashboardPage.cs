using AdvanceSpecFlowProject.Base;
using OpenQA.Selenium;

namespace AdvanceSpecFlow.PageObjectModel
{
    public class DashboardPage:BasePage
    {
        
        private By projectLeftBarButton => By.Id("projects-tab");
        private By projectBigButton => By.CssSelector("a[routerlink='/projects']");

       
        public ProjectPage ClickOnProjectLeftBar()
        {
            WaitAndClick(projectLeftBarButton);
            return new ProjectPage();
        }
        /*public void AssertError(string expectedResult)
        {
            _wait.Until(ExpectedConditions.UrlContains(expectedResult));
            string actualUrl = _driver.Url;
            StringAssert.StartsWith(expectedResult, actualUrl, "Projects is not succesful");
        }
        */
        public ProjectPage ClickOnProjectBigButton()
        {
            WaitAndClick(projectLeftBarButton);
            return new ProjectPage();
        }
    }
}
