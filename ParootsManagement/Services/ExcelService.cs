using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParootsManagement.Services
{
    public class ExcelService
    {
        private static string sheetName = "users";
        private static string ExcelFilePath => Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "ParootsManagement",
                    "users.xlsx");

        public static List<Dictionary<string, object>> ReadExcelData()
        {
            EnsureExcelFileExists();

            List<Dictionary<string, object>> excelData = new List<Dictionary<string, object>>();

            using (var package = new ExcelPackage(new FileInfo(ExcelFilePath)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("The workbook doesn't contain any worksheets.");
                    return excelData; // Return an empty list
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                if (worksheet != null && worksheet.Dimension != null)
                {
                    int rows = worksheet.Dimension.Rows;
                    int columns = worksheet.Dimension.Columns;

                    for (int row = 2; row <= rows; row++) // Assuming data starts from the second row (excluding headers)
                    {
                        Dictionary<string, object> rowValues = new Dictionary<string, object>();

                        for (int col = 1; col <= columns; col++)
                        {
                            string columnName = worksheet.Cells[1, col].Value?.ToString();
                            object cellValue = worksheet.Cells[row, col].Value;
                            rowValues.Add(columnName, cellValue);
                        }

                        excelData.Add(rowValues);
                    }
                }
            }

            return excelData;
        }
        public static void WriteExcelData(List<Dictionary<string, object>> data)
        {
            EnsureExcelFileExists();

            using (var package = new ExcelPackage(new FileInfo(ExcelFilePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == sheetName);

                // If the worksheet doesn't exist, create a new one
                if (worksheet == null)
                {
                    worksheet = package.Workbook.Worksheets.Add(sheetName);
                }

                // Get the last used row in the worksheet
                int lastUsedRow = worksheet.Dimension?.End.Row ?? 1;

                // Write data to the worksheet starting from the next empty row
                int newRow = lastUsedRow + 1;
                foreach (var rowData in data)
                {
                    int col = 1;
                    foreach (var cellValue in rowData.Values)
                    {
                        worksheet.Cells[newRow, col].Value = cellValue;
                        col++;
                    }
                    newRow++;
                }

                package.Save();
            }
        }

        private static void EnsureExcelFileExists()
        {
            string directoryPath = Path.GetDirectoryName(ExcelFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(ExcelFilePath))
            {
                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(sheetName); // Replace "Sheet1" with the desired sheet name
                                                                                           // Set headers in the worksheet
                    worksheet.Cells[1, 1].Value = "id";
                    worksheet.Cells[1, 2].Value = "username";
                    worksheet.Cells[1, 3].Value = "password";

                    package.SaveAs(new FileInfo(ExcelFilePath));
                }
            }
        }
    }
}

