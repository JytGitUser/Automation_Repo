using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MyTestProj.StepDefinitions
{
    [Binding]
    public class SpotifySignupStepDefinitions
    {
        private IWebDriver driver;

        private SignupPage SignupPage;


        [Given(@"I navigate to the Spotify signup page")]
        public void GivenINavigateToTheSpotifySignupPage()
        {
            driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
            SignupPage = new SignupPage(driver);

           // driver.Navigate().GoToUrl("https://www.spotify.com/in-en/signup?forward_url=https%3A%2F%2Fopen.spotify.com%2F");
            driver.Navigate().GoToUrl(" https://open.spotify.com/");

            driver.FindElement(By.XPath("(//*[contains(text(),'Sign up')])[3]")).Click();
            Thread.Sleep(5000);
          



        }


        [When(@"I enter my email as ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIEnterMyEmailAsAnd(string email, string passwordnew)
        {
            SignupPage.Email(email, passwordnew);
          

        }






        [When(@"I Enter Details")]
        public void WhenIEnterDetails()
        {
            SignupPage.EnternameDetails();

        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            SignupPage.ClickSignup();



        }

        [Then(@"I should be redirected to the Spotify welcome page and sign out")]
        public void ThenIShouldBeRedirectedToTheSpotifyWelcomePageAndSignOut()
        {
            SignupPage.Signout();

        }
    }
}
