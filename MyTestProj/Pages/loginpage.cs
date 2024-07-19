
using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EnterUsername(string username)
    {
        driver.FindElement(Locators.LoginPage.UsernameField).SendKeys(username);

    }

    public void EnterPassword(string password)
    {
        driver.FindElement(Locators.LoginPage.PasswordField).SendKeys(password);
    }

    public void ClickLogin()
    {
        driver.FindElement(Locators.LoginPage.LoginButton).Click();
    }

   // public bool IsErrorMessageDisplayed()
   // {
   //     return driver.FindElements(Locators.LoginPage.ErrorMessage).Count > 0;
   // }
}
