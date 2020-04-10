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
    public partial class posCheckout : Form
    {
        public posCheckout()
        {
            InitializeComponent();
        }
        public string tValue;
        public string pValue;
        public string rValue;
        public void transactionValue(string p)
        {
            tValue = p.ToString();
        }

        public void profitValue(string p)
        {
            pValue = p.ToString();
        }

        public void printReceipt(string p)
        {
            rValue = p.ToString();
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
            ucChange.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            var receipt = rValue.ToString();
            MessageBox.Show("[Receipt]"+ Environment.NewLine + receipt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Purchase");
            purchaseRegistry newRecord = new purchaseRegistry
            {
                posPurchaseDate = posdateTimePicker.Value.ToShortDateString(),
                posCost = ucTotalPrice.Text,
                posRetail = ucProfit.Text
            };
            pDatabase.addRecords("purchaseRecords", newRecord);

            SalesPOS formSalesPOS = new SalesPOS();
            formSalesPOS.ShowDialog();
            this.Close();
        }

        private void ucTotalPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void posCheckout_Load(object sender, EventArgs e)
        {
            ucTotalPrice.Text = tValue.ToString();
            ucProfit.Text = pValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((int.Parse(ucCashTendered.Text) >= int.Parse(ucTotalPrice.Text)) == true)
            {
                var transactedValue = int.Parse(ucCashTendered.Text) - int.Parse(ucTotalPrice.Text);
                ucChange.Text = transactedValue.ToString();
            }

            else
            {
                MessageBox.Show("[!] Insufficient Cash, Try Again! ");
                ucCashTendered.Text = "";

            }
        }

        private void ucProfit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
