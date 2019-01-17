using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NameLabelWriter.ExcelBuilder
{
    public class ExcelHandler : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private bool saveToExcel(List<Animal> animals)
        {
            Excel.Application excelApp;
            Excel.Workbooks workbooks;
            Excel.Workbook excelBook;
            try
            {
                Excel.Sheets sheets;
                Excel.Worksheet sheet;
                CreateInteropExcelObjectsFromTemplate(out excelApp, out workbooks, out excelBook, out sheets, out sheet);
                AppendToExcelTemplate(animals, sheet);
                SaveFileDialog sfd = createSafeFileDialog();


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    excelBook.SaveAs(sfd.FileName);
                    CloseAndRelease(excelApp, workbooks, excelBook, sheets, sheet);
                    return true;
                }
                else
                {
                    CloseAndRelease(excelApp, workbooks, excelBook, sheets, sheet);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // throw it
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static void CreateInteropExcelObjectsFromTemplate(out Excel.Application excelApp, out Excel.Workbooks workbooks, out Excel.Workbook excelBook, out Excel.Sheets sheets, out Excel.Worksheet sheet)
        {
            excelApp = new Excel.Application();
            workbooks = excelApp.Workbooks;
            excelBook = workbooks.Open(System.AppDomain.CurrentDomain.BaseDirectory + "etiketten.xlsx");
            sheets = excelBook.Worksheets;
            sheet = (Excel.Worksheet)(sheets[1]);
        }

        private static void AppendToExcelTemplate(List<Animal> animals, Excel.Worksheet sheet)
        {
            int cell = 1;
            int row = 2;
            foreach (Animal animal in animals)
            {

                sheet.Cells[cell, row] = animal.name;
                cell++;
                sheet.Cells[cell, row] = animal.countryOfOrigin;
                row += 2;
                if (row % 8 == 0)
                {
                    row = 2;
                    cell += 2;
                }
                else
                {
                    cell--;
                }
            }
        }

        private static void CloseAndRelease(Excel.Application excelApp, Excel.Workbooks workbooks, Excel.Workbook excelBook, Excel.Sheets sheets, Excel.Worksheet sheet)
        {
            excelApp.DisplayAlerts = false;
            Marshal.ReleaseComObject(sheet);
            Marshal.ReleaseComObject(sheets);
            excelBook.Save();
            excelBook.Close(true);
            Marshal.ReleaseComObject(excelBook);
            Marshal.ReleaseComObject(workbooks);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
