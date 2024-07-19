// Locators.cs
using OpenQA.Selenium;

public static class Locators
{
    public static class LoginPage
    {
        public static readonly By UsernameField = By.XPath("//input[@id='login-username']");
        public static readonly By PasswordField = By.XPath("//input[@id='login-password']");
        public static readonly By LoginButton = By.XPath("//*[@id='login-button']");
        //  public static readonly By ErrorMessage = By.XPath("//*[@class='Message-sc-15vkh7g-0 dHbxKh']]");
    

        public static readonly By EmailFieldId = By.XPath("//*[@id='username']");
        public static readonly By PasswordNew = By.XPath("//*[@id='new-password']");
        public static readonly By NameField = By.XPath("//*[@name='displayName']");
        public static readonly By BirthYear = By.XPath("//*[@data-testid='birthDateYear']");

        public static readonly By BirhMonth= By.XPath("//*[@name='month']");
        public static readonly By BirthDate = By.XPath("//*[@id='day']");
        public static readonly By Nextbtn = By.XPath("//*[@class='Button-sc-qlcn5g-0 cUOgcY']"); 

        public static readonly By Gender = By.XPath("(//*[@class='Indicator-sc-hjfusp-0 jeEHZA'])[1]");
        public static readonly By Signupbtn = By.XPath("//span[text()='Sign up']");
       // public static readonly By signout = By.XPath("//*[contains(text(),'Log out')]");
        
    }
}
