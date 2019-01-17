using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NameLabelWriter
{
    public partial class FindAnimal : Form
    {
        NameLabelWriter wrt;
        List<Animal> animals = null;

        public FindAnimal(NameLabelWriter wrt)
        {            
            InitializeComponent();
            animals = new List<Animal>();
            this.wrt = wrt;
            lbAnimalsToPrint.Items.Clear();
            foreach (Animal animal in wrt.animalsToPrint)
            {
                lbAnimalsToPrint.Items.Add(animal);
            }
        }

        private void btnFindAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                lbResults.Items.Clear();
                foreach (Animal animal in wrt.animalRepo.getAnimalsByName(txtFindAnimal.Text))
                {
                    lbResults.Items.Add(animal);
                    
                }
                if (lbResults.Items.Count == 1)
                {
                    lbResults.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbResults.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                lbAnimalsToPrint.Items.Add(selectedAnimal);
                wrt.animalsToPrint.Add(selectedAnimal);
            }
            else
            {
                MessageBox.Show("Selecteer en dier om toe te voegen aan de lijst");
            }
            label4.Text = "Aantal naamkaartjes: " + wrt.animalsToPrint.Count;
            lbAnimalsToPrint.SelectedIndex = lbAnimalsToPrint.Items.Count - 1;
        }

        private void btnDeleteAnimalFromList_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbAnimalsToPrint.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                wrt.animalsToPrint.RemoveAll(x => x.id == selectedAnimal.id);
                lbAnimalsToPrint.Items.Clear();
                foreach (Animal animal in wrt.animalsToPrint)
                {
                    lbAnimalsToPrint.Items.Add(animal);
                }
            }
            else
            {
                MessageBox.Show("Selecteer en dier om toe te voegen aan de lijst");
            }
            label4.Text = "Aantal naamkaartjes: " + wrt.animalsToPrint.Count;
        }

        private void btnCreateExcelFile_Click(object sender, EventArgs e)
        {
            if (saveToExcel(wrt.animalsToPrint))
            {
                wrt.animalsToPrint.Clear();
                lbAnimalsToPrint.Items.Clear();                
            }
            label4.Text = "Aantal naamkaartjes: " + wrt.animalsToPrint.Count;         
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
                MessageBox.Show(ex.Message);
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

        private SaveFileDialog createSafeFileDialog()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DateTime date = DateTime.Now;
            string filename = date.ToString();
            sfd.FileName = replaceChars(filename);
            sfd.Filter = "Excel Files(.xlsx)|*.xlsx";
            return sfd;
        }

        public string replaceChars(string filename)
        {
            filename = filename.Replace('/', '-');
            filename = filename.Replace(':', '.');
            return filename;
        }

        private void txtFindAnimal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindAnimal_Click(this, new EventArgs());
            }
        }
    }
}
