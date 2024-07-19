// SpotifyLoginSteps.cs
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

[Binding]
public class SpotifyLoginSteps
{
    private IWebDriver driver;
    private LoginPage loginPage;
   

    private readonly ExcelReader excelReader = new ExcelReader();

    [Given(@"I navigate to the Spotify login page")]
    public void GivenINavigateToTheSpotifyLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://accounts.spotify.com/en/login");
        loginPage = new LoginPage(driver);
    }



    [When(@"I enter username ""([^""]*)"" and password ""([^""]*)""")]
    public void WhenIEnterUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsername(username,password);
        
        
    }

    [When(@"I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        loginPage.ClickLogin();
    }



    [Then(@"I should see an error message if login fails for ""([^""]*)""")]
    public void ThenIShouldSeeAnErrorMessageIfLoginFailsFor(string username)

    {
        Thread.Sleep(5000);
        driver.Quit();
    }






    
}