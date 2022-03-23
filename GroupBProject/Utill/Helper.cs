using GroupBProject.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.Text;

namespace GroupBProject.Utill
{
    public class Helper : IHelper
    {
        public string EmployeeFileWrite(Employee newEmployee)
        {
            {
                // Creating an instance
                // of ExcelPackage
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                ExcelPackage excel = new ExcelPackage();

                // name of the sheet
                var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                // setting the properties
                // of the work sheet 
                workSheet.TabColor = System.Drawing.Color.Black;
                workSheet.DefaultRowHeight = 12;

                // Setting the properties
                // of the first row
                workSheet.Row(1).Height = 20;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;

                // Header of the Excel sheet
                workSheet.Cells[1, 1].Value = "ID";
                workSheet.Cells[1, 2].Value = "Name";
                workSheet.Cells[1, 3].Value = "Age";
                workSheet.Cells[1, 4].Value = "DOB";
                workSheet.Cells[1, 5].Value = "Designation";

                //Second line of excel sheet

                workSheet.Cells[2, 1].Value = newEmployee.ID;
                workSheet.Cells[2, 2].Value=newEmployee.Name;
                workSheet.Cells[2, 3].Value = newEmployee.Age;
                workSheet.Cells[2, 4].Value = newEmployee.DOB;
                workSheet.Cells[2, 5].Value = newEmployee.Designation;


                // file name with .xlsx extension 
                string p_strPath = @"C:\Users\user\source\repos\GroupBProject\GroupBProject\StaticFiles\Sample.xlsx";

                if (File.Exists(p_strPath))
                    File.Delete(p_strPath);

                // Create excel file on physical disk 
                FileStream objFileStrm = File.Create(p_strPath);
                objFileStrm.Close();

                // Write content to excel file 
                File.WriteAllBytes(p_strPath, excel.GetAsByteArray());
                //Close Excel package
                excel.Dispose();
                Console.WriteLine("Submit");
                Console.ReadKey();

                return p_strPath;


            }
        }

    }
}
