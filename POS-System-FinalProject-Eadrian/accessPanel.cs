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
    public partial class accessPanel : Form
    {
        public accessPanel()
        {
            InitializeComponent();
        }
        string peepsUsername;
        string peepsPassword;

        private void loginUsername_TextChanged(object sender, EventArgs e)
        {
            peepsUsername = loginUsername.Text;
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            peepsPassword = loginPassword.Text;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Workforce");
            var records = pDatabase.checkRecords<Workforce>("adminPeeps");

            foreach (var record in records)
            {
                if (record.loginUsername == peepsUsername && record.loginPassword == peepsPassword)
                {
                    this.Hide();
                    AdminPanel formAP = new AdminPanel();
                    formAP.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("[!] Incorrect Credentials. ");
                    loginUsername.Text = "";
                    loginPassword.Text = "";
                    Dashboard formDashB = new Dashboard();
                    formDashB.ShowDialog();
                    this.Close();
                }

            }
        }

        
    }
}
