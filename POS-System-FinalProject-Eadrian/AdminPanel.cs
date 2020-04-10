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
            var peepsCateg = peepsCategory.SelectedItem.ToString()
            if(peepsCateg == "Administrator") 
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
        }
    }
}
