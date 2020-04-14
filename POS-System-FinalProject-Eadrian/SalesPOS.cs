using MongoDB.Bson;
using MongoDB.Driver;
using POS_System_FinalProject_Eadrian;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;


namespace POSSystemOOPFinals
{
    public partial class SalesPOS : Form
    {




        public SalesPOS()
        {
            InitializeComponent();
        }

     

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow formLW = new LoginWindow();
            formLW.ShowDialog();
            this.Close();
        }


        private void inventoryIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory formInventory = new Inventory();
            formInventory.ShowDialog();
            this.Close();
        }

        public string purchaseValue;
        public string purchaseProfit;
        public string purchaseReceipt; 

        private void button2_Click(object sender, EventArgs e)
        {
            purchaseValue = posTotalPrice.Text;
            purchaseProfit = productProfit.Text;
            purchaseReceipt = posPurchaseTB.Text;
            posCheckout posUc = new posCheckout();
            posUc.transactionValue(purchaseValue.ToString());
            posUc.profitValue(purchaseProfit.ToString());
            posUc.printReceipt(purchaseReceipt.ToString());
            posUc.ShowDialog();
        }

        private void posPastryDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.posPastryDV.Columns["Id"].Visible = false;
            this.posPastryDV.Columns["productRetail"].Visible = false;
            this.posPastryDV.Columns["productQuantity"].Visible = false;
            this.posPastryDV.Columns["productCost"].Visible = false;
            this.posPastryDV.Columns["productSupplier"].Visible = false;
            this.posPastryDV.Columns["productCategory"].Visible = false;
            this.posPastryDV.Columns["productDate"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Pastry";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            posPastryDV.DataSource = filtered;
            posPastryDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void posSweetsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.posSweetsDV.Columns["Id"].Visible = false;
            this.posSweetsDV.Columns["productRetail"].Visible = false;
            this.posSweetsDV.Columns["productQuantity"].Visible = false;
            this.posSweetsDV.Columns["productCost"].Visible = false;
            this.posSweetsDV.Columns["productSupplier"].Visible = false;
            this.posSweetsDV.Columns["productCategory"].Visible = false;
            this.posSweetsDV.Columns["productDate"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Sweets";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            posSweetsDV.DataSource = filtered;
            posSweetsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        private void posMeatsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.posMeatsDV.Columns["Id"].Visible = false;
            this.posMeatsDV.Columns["productRetail"].Visible = false;
            this.posMeatsDV.Columns["productQuantity"].Visible = false;
            this.posMeatsDV.Columns["productCost"].Visible = false;
            this.posMeatsDV.Columns["productSupplier"].Visible = false;
            this.posMeatsDV.Columns["productCategory"].Visible = false;
            this.posMeatsDV.Columns["productDate"].Visible = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Meats";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            posMeatsDV.DataSource = filtered;
            posMeatsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void posDrinksDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.posDrinksDV.Columns["Id"].Visible = false;
            this.posDrinksDV.Columns["productRetail"].Visible = false;
            this.posDrinksDV.Columns["productQuantity"].Visible = false;
            this.posDrinksDV.Columns["productCost"].Visible = false;
            this.posDrinksDV.Columns["productSupplier"].Visible = false;
            this.posDrinksDV.Columns["productCategory"].Visible = false;
            this.posDrinksDV.Columns["productDate"].Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Drinks";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            posDrinksDV.DataSource = filtered;
            posDrinksDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void posFruitsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.posFruitsDV.Columns["Id"].Visible = false;
            this.posFruitsDV.Columns["productRetail"].Visible = false;
            this.posFruitsDV.Columns["productQuantity"].Visible = false;
            this.posFruitsDV.Columns["productCost"].Visible = false;
            this.posFruitsDV.Columns["productSupplier"].Visible = false;
            this.posFruitsDV.Columns["productCategory"].Visible = false;
            this.posFruitsDV.Columns["productDate"].Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Fruits";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            posFruitsDV.DataSource = filtered;
            posFruitsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
           
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Products");
            IMongoCollection<Product> records = pDatabase.GetCollection<Product>("productList");

            if (productPurchaseQuantity.Text != "")
            {
                var productPurchase = int.Parse(productStockTB.Text) - int.Parse(productPurchaseQuantity.Text);

                if ((int.Parse(productPurchaseQuantity.Text) <= int.Parse(productStockTB.Text)) == true)
                {
                    var recordsUpdate = Builders<Product>.Update.Set(p => p.productQuantity, productPurchase.ToString());
                    records.UpdateOne(s => s.Id == ObjectId.Parse(productIdTB.Text), recordsUpdate);

                    var oldValueP = int.Parse(posTotalPrice.Text);
                    var oldValueR = int.Parse(productProfit.Text);
                    
                    var newValueP = int.Parse(productPrice.Text) * int.Parse(productPurchaseQuantity.Text);
                    posTotalPrice.Text = (oldValueP + newValueP).ToString();
                    var newValueR = int.Parse(productCost.Text) * int.Parse(productPurchaseQuantity.Text);
                    var newProfit = (newValueP - newValueR);
                    productProfit.Text = (oldValueR + newProfit).ToString();
                    posPurchaseTB.Text += "> " + productNameTB.Text + " x" + productPurchaseQuantity.Text + " = " + newValueP.ToString() + Environment.NewLine;
                    productIdTB.Text = "";
                    productNameTB.Text = "";
                    productPrice.Text = "";
                    productCost.Text = "";
                    productPurchaseQuantity.Text = "";
                    productStockTB.Text = "";
                }

                else
                {
                    MessageBox.Show("[!] Insufficient Stocks, Please Try Again!");
                }
            }

            else
            {
                MessageBox.Show("[!] Please Enter the desired quantity for the product");
            }
        }

        

        private void button14_Click_1(object sender, EventArgs e)
        {
            productNameTB.Text = "";
            productPrice.Text = "";
            productPurchaseQuantity.Text = "";
        }

        private void SalesPOS_Load(object sender, EventArgs e)
        {
            posTotalPrice.Text = "0";
            productProfit.Text = "0";
        }


        private void posSweetsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = posSweetsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = posSweetsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productStockTB.Text = posSweetsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCost.Text = posSweetsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text = posSweetsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void posPastryDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = posPastryDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = posPastryDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productStockTB.Text = posPastryDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCost.Text = posPastryDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text = posPastryDV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void posMeatsDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = posMeatsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = posMeatsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productStockTB.Text = posMeatsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCost.Text = posMeatsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text = posMeatsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void posDrinksDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = posDrinksDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = posDrinksDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productStockTB.Text = posDrinksDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCost.Text = posDrinksDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text = posDrinksDV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void posFruitsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = posFruitsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = posFruitsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productStockTB.Text = posFruitsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCost.Text = posFruitsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productPrice.Text = posFruitsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void posIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void posSweets_Click(object sender, EventArgs e)
        {

        }

        private void ScreenTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        public void posTabs_Selected(object sender, TabControlEventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void productQuantityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPastry_Click(object sender, EventArgs e)
        {

        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void productNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    
        
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void productPurchaseQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void posMeats_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void posSweetsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void productStockTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            accessPanel formAP = new accessPanel();
            formAP.ShowDialog();
            this.Close();
        }

        private void reportIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
