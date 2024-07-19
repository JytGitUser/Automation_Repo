
using OfficeOpenXml;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }


    [DynamicData(nameof(ReadExcel),DynamicDataSourceType.Method)]
    public void EnterUsername(string username, string password)
    {
        driver.FindElement(Locators.LoginPage.UsernameField).SendKeys(username);
        driver.FindElement(Locators.LoginPage.PasswordField).SendKeys(password);

    }

    public static IEnumerable<object[]> ReadExcel()
    {
        using (ExcelPackage package = new ExcelPackage(new FileInfo("Userdata.xlsx")))
        {

            // Create worksheet object
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
            int rowCount = worksheet.Dimension.End.Row;
            for (int i = 2; i <= rowCount; i++)
            {
                yield return new object[]
                {
            worksheet.Cells[i, 1]?.Value?.ToString().Trim(), 
            worksheet.Cells[i, 2]?.Value?.ToString().Trim(), 
                };
            } } }



            public void ClickLogin()
            {
                driver.FindElement(Locators.LoginPage.LoginButton).Click();
            }

            // public bool IsErrorMessageDisplayed()
            // {
            //     return driver.FindElements(Locators.LoginPage.ErrorMessage).Count > 0;
            // }
        } 
