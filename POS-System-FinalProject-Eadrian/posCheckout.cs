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

        public void transactionValue(string p)
        {
            tValue = p.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MongoClient client = new MongoClient();
            //IMongoDatabase pDatabase = client.GetDatabase("Products");
            //IMongoCollection<Product> records = pDatabase.GetCollection<Product>("productList");

            //var recordsUpdate = Builders<Product>.Update.Set
            //    (p => p.productQuantity, productQuantityTB.Text).Set
            //    (p => p.productCost, productCostTB.Text).Set
            //    (p => p.productRetail, productRetailTB.Text).Set
            //    (p => p.productSupplier, productSupplierTB.Text).Set
            //    (p => p.productCategory, productlistCategory.GetItemText(productlistCategory.SelectedItem).ToString()).Set
            //    (p => p.productDate, productdateTimePicker.Value.ToShortDateString());
            //records.UpdateOne(s => s.Id == ObjectId.Parse(productIdTB.Text), recordsUpdate);
        }

        private void ucTotalPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void posCheckout_Load(object sender, EventArgs e)
        {
            ucTotalPrice.Text = tValue.ToString();
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
    }
}
