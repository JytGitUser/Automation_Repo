// ExcelReader.cs
using System.Collections.Generic;
using System.IO;
using Gherkin.CucumberMessages.Types;
using LivingDoc.Dtos;
using OfficeOpenXml;

public class ExcelReader

    
{

    public List<(string username, string password,bool invalid)> ReadCredentials(string filePath)
    {
        filePath = @"Utils\Userdata.xlsx";

      var credentials = new List<(string, string, bool)>();

        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            var worksheet = package.Workbook.Worksheets[0];
            int rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Assuming first row is header
            {
                var username = worksheet.Cells[row, 1].Text; // Column A
                var password = worksheet.Cells[row, 2].Text; // Column B
                var isValid = worksheet.Cells[row, 3].Text.ToLower() == "true"; // Column C
                credentials.Add((username, password, isValid));
            }
        }

        return credentials;
    }
}
