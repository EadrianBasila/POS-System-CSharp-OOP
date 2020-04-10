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
                    dateHired = approductdateTimePicker.Value.ToShortDateString()
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
                    dateHired = approductdateTimePicker.Value.ToShortDateString()
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
                    (p => p.dateHired, approductdateTimePicker.Value.ToShortDateString());
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
                    (p => p.dateHired, approductdateTimePicker.Value.ToShortDateString());
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
            approductdateTimePicker.Value = Convert.ToDateTime(adminAdminDV.Rows[0].Cells[7].Value.ToString());
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
            approductdateTimePicker.Value = Convert.ToDateTime(adminEmployeeDV.Rows[0].Cells[7].Value.ToString());
        }

        private void adminAdminDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIdTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            employeeNameTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminAdminDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            peepsCategory.Text = adminAdminDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            approductdateTimePicker.Text = adminAdminDV.Rows[e.RowIndex].Cells[7].Value.ToString();       
        }

        private void adminEmployeeDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIdTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            employeeNameTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeUsernameTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            employeePasswordTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            employeeSalaryTB.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            peepsCategory.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            approductdateTimePicker.Text = adminEmployeeDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
