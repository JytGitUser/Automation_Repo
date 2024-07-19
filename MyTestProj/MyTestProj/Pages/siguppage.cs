using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class SignupPage
{
    private readonly IWebDriver driver;

    public SignupPage(IWebDriver driver)
    {
        this.driver = driver;
        
    }

    public void Email(String email, String passwordnew)
    {
        driver.FindElement(Locators.LoginPage.EmailFieldId).SendKeys(email);
        Thread.Sleep(5000);
        driver.FindElement(Locators.LoginPage.Nextbtn).Click();
        Thread.Sleep(5000);
        driver.FindElement(Locators.LoginPage.PasswordNew).SendKeys(passwordnew);
        Thread.Sleep(5000);
        driver.FindElement(Locators.LoginPage.Nextbtn).Click();

    }

       
    public void EnternameDetails()
    {

        driver.FindElement(Locators.LoginPage.NameField).SendKeys("Shaam");

        driver.FindElement(Locators.LoginPage.BirthYear).SendKeys("1988");

        //  driver.FindElement(Locators.LoginPage.BirhMonth);
        Thread.Sleep(5000);
        var monthDropdown = driver.FindElement(By.XPath("//*[@name='month']")); 
        SelectElement selectElement = new SelectElement(monthDropdown);

        selectElement.SelectByText("May");


        driver.FindElement(Locators.LoginPage.BirthDate).SendKeys("22");

        driver.FindElement(Locators.LoginPage.Gender).Click();

        driver.FindElement(Locators.LoginPage.Nextbtn).Click();

    }

    public void ClickSignup()
    {
        driver.FindElement(Locators.LoginPage.Signupbtn).Click();
    }

    public void Signout()


    {
        
        driver.Quit();
    }
}
