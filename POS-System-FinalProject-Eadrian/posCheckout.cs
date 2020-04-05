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
    public partial class posCheckout : Form
    {
        public posCheckout()
        {
            InitializeComponent();
        }


        private void ucBt1_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "1";

        }

        private void ucCashTendered_Enter(object sender, EventArgs e)
        {
         
        }

        private void ucCashTendered_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucCashTendered.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBt2_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "2";
        }

        private void ucBt3_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "3";
        }

        private void ucBt4_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "4";
        }

        private void ucBt5_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "5";
        }

        private void ucBt6_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "6";
        }

        private void ucBt7_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "7";
        }

        private void ucBt8_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "8";
        }

        private void ucBt9_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "9";
        }

        private void ucBt0_Click(object sender, EventArgs e)
        {
            this.ucCashTendered.Text += "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
