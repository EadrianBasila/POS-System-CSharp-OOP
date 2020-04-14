using MongoDB.Bson;
using MongoDB.Driver;
using POSSystemOOPFinals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_FinalProject_Eadrian
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var peepsCateg = peepsCategory.SelectedItem.ToString();
            if (peepsCateg == "Administrator")
            {
                recordDatabase pDatabase = new recordDatabase("Workforce");
                Workforce newPeeps = new Workforce
                {
                    employeeName = employeeNameTB.Text,
                    loginUsername = employeeUsernameTB.Text,
                    loginPassword = employeePasswordTB.Text,
                    employeeSalary = employeeSalaryTB.Text,
                    employeeCategory = peepsCategory.SelectedItem.ToString(),
                    dateHired = apdateTimePicker.Value.ToShortDateString()
                };
                pDatabase.addRecords("adminPeeps", newPeeps);
            }
            else 
            {
                recordDatabase pDatabase = new recordDatabase("Workforce");
                Workforce newPeeps = new Workforce
                {
                    employeeName = employeeNameTB.Text,
                    loginUsername = employeeUsernameTB.Text,
                    loginPassword = employeePasswordTB.Text,
                    employeeSalary = employeeSalaryTB.Text,
                    employeeCategory = peepsCategory.SelectedItem.ToString(),
                    dateHired = apdateTimePicker.Value.ToShortDateString()
                };
                pDatabase.addRecords("Peeps", newPeeps);
            }
            loadAdmin.PerformClick();
            loadEmployee.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Workforce");
            
            var peepsCateg = peepsCategory.SelectedItem.ToString();
            if (peepsCateg == "Administrator")
            {
                IMongoCollection<Workforce> records = pDatabase.GetCollection<Workforce>("adminPeeps");

                var recordsUpdate = Builders<Workforce>.Update.Set
                    (p => p.employeeName, employeeNameTB.Text).Set
                    (p => p.loginUsername, employeeUsernameTB.Text).Set
                    (p => p.loginPassword, employeePasswordTB.Text).Set
                    (p => p.employeeSalary, employeeSalaryTB.Text).Set
                    (p => p.employeeCategory, peepsCategory.GetItemText(peepsCategory.SelectedItem).ToString()).Set
                    (p => p.dateHired, apdateTimePicker.Value.ToShortDateString());
                records.UpdateOne(s => s.Id == ObjectId.Parse(employeeIdTB.Text), recordsUpdate);
            }
            else 
            {
                IMongoCollection<Workforce> records = pDatabase.GetCollection<Workforce>("Peeps");

                var recordsUpdate = Builders<Workforce>.Update.Set
                    (p => p.employeeName, employeeNameTB.Text).Set
                    (p => p.loginUsername, employeeUsernameTB.Text).Set
                    (p => p.loginPassword, employeePasswordTB.Text).Set
                    (p => p.employeeSalary, employeeSalaryTB.Text).Set
                    (p => p.employeeCategory, peepsCategory.GetItemText(peepsCategory.SelectedItem).ToString()).Set
                    (p => p.dateHired, apdateTimePicker.Value.ToShortDateString());
                records.UpdateOne(s => s.Id == ObjectId.Parse(employeeIdTB.Text), recordsUpdate);
            }

            loadAdmin.PerformClick();
            loadEmployee.PerformClick();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Workforce");
            var peepsCateg = peepsCategory.SelectedItem.ToString();
            if (peepsCateg != "Administrator")
            {
                IMongoCollection<Workforce> records = pDatabase.GetCollection<Workforce>("Peeps");
                records.DeleteOne(p => p.Id == ObjectId.Parse(employeeIdTB.Text));
                loadAdmin.PerformClick();
                loadEmployee.PerformClick();
            }

            else
            {
                MessageBox.Show("[!] Unable to perform task.");
            }
        }

        private void adminAdminDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void loadAdmin_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Workforce");
            var records = pDatabase.checkRecords<Workforce>("adminPeeps");
            var pCategory = "Administrator";
            List<Workforce> filtered = records.Where(x => x.employeeCategory == pCategory).ToList();
            adminAdminDV.DataSource = filtered;
            adminAdminDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            employeeIdTB.Text = adminAdminDV.Rows[0].Cells[0].Value.ToString();
            employeeNameTB.Text = adminAdminDV.Rows[0].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminAdminDV.Rows[0].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminAdminDV.Rows[0].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminAdminDV.Rows[0].Cells[4].Value.ToString();
            peepsCategory.Text= adminAdminDV.Rows[0].Cells[5].Value.ToString();
            apdateTimePicker.Value = Convert.ToDateTime(adminAdminDV.Rows[0].Cells[6].Value.ToString());
        }

        private void loadEmployee_Click(object sender, EventArgs e)
        {

            recordDatabase pDatabase = new recordDatabase("Workforce");
            var records = pDatabase.checkRecords<Workforce>("Peeps");
            var pCategory = "Employee";
            List<Workforce> filtered = records.Where(x => x.employeeCategory == pCategory).ToList();
            adminEmployeeDV.DataSource = filtered;
            adminEmployeeDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            employeeIdTB.Text = adminEmployeeDV.Rows[0].Cells[0].Value.ToString();
            employeeNameTB.Text = adminEmployeeDV.Rows[0].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminEmployeeDV.Rows[0].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminEmployeeDV.Rows[0].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminEmployeeDV.Rows[0].Cells[4].Value.ToString();
            peepsCategory.Text = adminEmployeeDV.Rows[0].Cells[5].Value.ToString();
            apdateTimePicker.Value = Convert.ToDateTime(adminEmployeeDV.Rows[0].Cells[6].Value.ToString());
        }

        private void adminAdminDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIdTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            employeeNameTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            peepsCategory.Text = adminAdminDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            apdateTimePicker.Text = adminAdminDV.Rows[e.RowIndex].Cells[6].Value.ToString();       
        }

        private void adminEmployeeDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIdTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            employeeNameTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            peepsCategory.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            apdateTimePicker.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void loadSales_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Purchase");
            var records = pDatabase.checkRecords<purchaseRegistry>("purchaseRecords");          
            adminSalesDV.DataSource = records;
            adminSalesDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void loadShifts_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("EmployeeShifts");
            var records = pDatabase.checkRecords<Workshift>("workShifts");
            adminShiftsDV.DataSource = records;
            adminShiftsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow formLW = new LoginWindow();
            formLW.ShowDialog();
            this.Close();
        }

        private void posIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPOS formSalesP = new SalesPOS();
            formSalesP.ShowDialog();
            this.Close();
        }

        private void inventoryIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory formInventory = new Inventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            employeeIdTB.Text = "";
            employeeNameTB.Text = "";
            employeeUsernameTB.Text = "";
            employeePasswordTB.Text = "";
            employeeSalaryTB.Text = "";
            peepsCategory.Text = "";
         
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];


            if (adminTabs.SelectedTab.Name == "tabAdmin")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Admin-Admins";
                loadAdmin.PerformClick();

                for (int i = 1; i < adminAdminDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = adminAdminDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < adminAdminDV.Rows.Count; i++)
                {
                    for (int j = 0; j < adminAdminDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = adminAdminDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsAdmins-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (adminTabs.SelectedTab.Name == "tabEmployee")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Admin-Employees";
                loadEmployee.PerformClick();

                for (int i = 1; i < adminEmployeeDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = adminEmployeeDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < adminEmployeeDV.Rows.Count; i++)
                {
                    for (int j = 0; j < adminEmployeeDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = adminEmployeeDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsEmployee-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (adminTabs.SelectedTab.Name == "tabSales")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Admin-Sales";
                loadSales.PerformClick();

                for (int i = 1; i < adminSalesDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = adminSalesDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < adminSalesDV.Rows.Count; i++)
                {
                    for (int j = 0; j < adminSalesDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = adminSalesDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsSales-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (adminTabs.SelectedTab.Name == "tabWorkshift")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Admin-Workshifts";
                loadShifts.PerformClick();

                for (int i = 1; i < adminShiftsDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = adminShiftsDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < adminShiftsDV.Rows.Count; i++)
                {
                    for (int j = 0; j < adminShiftsDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = adminShiftsDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsShifts-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }
            
            else
            {
                MessageBox.Show("[!] Exporting Error.");
            }
        }
    }
}
