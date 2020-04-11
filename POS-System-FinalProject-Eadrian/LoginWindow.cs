using POS_System_FinalProject_Eadrian;
using System;
using System.Windows.Forms;




namespace POSSystemOOPFinals
{
    public partial class LoginWindow : Form
    {

        string peepsUsername;
        string peepsPassword;

        public LoginWindow()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void loginUsername_TextChanged(object sender, EventArgs e)
        {
            peepsUsername = loginUsername.Text;
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            peepsPassword = loginPassword.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {


            recordDatabase pDatabase = new recordDatabase("Workforce");

            if (adminLogin.Checked)
            {
                var records = pDatabase.checkRecords<Workforce>("adminPeeps");

                foreach (var record in records)
                {
                    if (record.loginUsername == peepsUsername && record.loginPassword == peepsPassword)
                    {
                        recordDatabase sDatabase = new recordDatabase("EmployeeShifts");                      
                        Workshift newRecord = new Workshift
                        {
                            employeeUsername = loginUsername.Text,
                            shiftDate = lwdateTimePicker.Value.ToShortDateString()                                                  
                        };
                        sDatabase.addRecords("workShifts", newRecord);

                        this.Hide();
                        Dashboard formDashB = new Dashboard();
                        formDashB.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("[!] Incorrect Credentials. Please Try Again!");
                        adminLogin.Checked = false;
                        loginUsername.Text = "";
                        loginPassword.Text= "";
                    }

                }

            }

            else
            {
                var records = pDatabase.checkRecords<Workforce>("Peeps");

                foreach (var record in records)
                {
                    if (record.loginUsername == peepsUsername && record.loginPassword == peepsPassword)
                    {
                        recordDatabase sDatabase = new recordDatabase("EmployeeShifts");
                        Workshift newRecord = new Workshift
                        {
                            employeeUsername = loginUsername.Text,
                            shiftDate = lwdateTimePicker.Value.ToShortDateString()
                        };
                        sDatabase.addRecords("workShifts", newRecord);

                        this.Hide();
                        Dashboard formDashB = new Dashboard();
                        formDashB.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("[!] Incorrect Credentials. Please Try Again!");
                        loginUsername.Text = "";
                        loginPassword.Text = "";
                    }

                }

            }

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void loginUsername_Enter(object sender, EventArgs e)
        {

            if (loginUsername.Text.Equals(@""))
            {
                loginUsername.Text = "";
            }
        }


        private void loginUsername_Leave(object sender, EventArgs e)
        {
            if (loginUsername.Text.Equals(@""))
            {
                loginUsername.Text = "";
            }
        }

        private void loginPassword_Enter(object sender, EventArgs e)
        {
            if (loginUsername.Text.Equals(@""))
            {
                loginUsername.Text = "";
            }
        }

        private void loginPassword_Leave(object sender, EventArgs e)
        {
            if (loginUsername.Text.Equals(@""))
            {
                loginUsername.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
