using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTestProj.StepDefinitions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MyTestProj.StepDefinitions
{
    [Binding]
    public class GoogleSteps
    {
        private  IWebDriver driver;

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [When(@"I navigate to Google")]
        public void WhenINavigateToGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Then(@"the Google homepage should be displayed")]
        public void ThenTheGoogleHomepageShouldBeDisplayed()
        {
            var pageTitle = driver.Title;
            if (pageTitle != "Google")
            {
                throw new Exception("Google homepage is not displayed.");
            }


            driver.Quit();
        }
    }
}
