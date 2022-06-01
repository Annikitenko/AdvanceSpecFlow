using AdvanceSpecFlowProject.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvanceSpecFlow.PageObjectModel
{
    public class ProjectPage:BasePage
    {
        private string _projectName;

        private By allProjectButton => By.XPath("//div[contains(text(), ' All ')]");
        private By searchFieldInput => By.XPath("//input[@class='input-search']");
        private By foundProject => By.XPath($"//h4[contains (text(), '{_projectName}')]");

        private By logoButton => By.XPath("//button[@class='add-image-btn']");
        private By generalButton => By.XPath("//a[contains (text(),'General')]");

        private By editButton =>By.XPath("//a[contains (text(),'Edit')]");
        private By inputFile =>By.XPath("//input[@type='file']");

        private By saveButton => By.XPath("//span[contains(text(),'Save')]");

        private By logo => By.XPath("//div[@class='selected-status-wrapper image ng-star-inserted']");

 /*
        public ProjectPage ClickOnAllProjectButton()
        {
            WaitAndClick(allProjectButton);
            return new ProjectPage();
        }
        
       public void SearchProject(string _projectName)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(searchFieldInput)).Click();
            searchFieldInput.SendKeys(_projectName);
        }
        public void SelectProject(string _projectName)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath($"//span[contains(text(), '{_projectName}')]")))).Click();
        }
        public void AssertError(string expectedResult)
        {
            Thread.Sleep(2000);
            string actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(foundProject)).Text;
            StringAssert.EndsWith(expectedResult, actualResult, "Project is not found");
        }

        //Download Logo
        public void SelectGeneralInProjects()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(generalButton)).Click();

        }
        public void SelectEditInProjects()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(editButton)).Click();
        }

        public void DownloadLogo()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(logoButton));
            inputFile.SendKeys("C:\\Users\\Amdaris\\HomeWork\\3.16 Page Object Pattern\\Pudel4.jpg");
        }
        public void AssertErrorLogo()
        {
            Assert.AreEqual(logo, _wait.Until(ExpectedConditions.ElementToBeClickable(logo)), "logo is not presented");
        }
        public void SaveLogo()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_driver.FindElement(By.XPath("//button[@type = 'submit']")))).Click();
        }

        public void DownloadBigLogo()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(logoButton));
            inputFile.SendKeys("C:\\Users\\Amdaris\\HomeWork\\3.16 Page Object Pattern\\pudel_Big_Size.jpg");
        }

        public void AssertErrorBigLogo()
        {
            _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(".error-message")));
            string actualResult = _driver.FindElement(By.CssSelector(".error-message")).Text;
            Assert.AreEqual("Image must not be larger than 5 MB", actualResult);
        }
      */
    }
}
