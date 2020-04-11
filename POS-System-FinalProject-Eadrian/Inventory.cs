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
using MongoDB.Bson;
using MongoDB.Driver;

namespace POS_System_FinalProject_Eadrian
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void ScreenTitle_Click(object sender, EventArgs e)
        {

        }

        private void tabMeats_Click(object sender, EventArgs e)
        {

        }

        private void tabDrinks_Click(object sender, EventArgs e)
        {

        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard formDashboard = new Dashboard();
            formDashboard.ShowDialog();
            this.Close();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void posIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPOS formSalesP = new SalesPOS();
            formSalesP.ShowDialog();
            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void productlistCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            Product newProduct = new Product
            {
                productName = productNameTB.Text,
                productQuantity = productQuantityTB.Text,
                productCost = productCostTB.Text,
                productRetail = productRetailTB.Text,
                productSupplier = productSupplierTB.Text,
                productCategory = productlistCategory.SelectedItem.ToString(),
                productDate = productdateTimePicker.Value.ToShortDateString()

            };
            pDatabase.addRecords("productList", newProduct);

            invButtonS.PerformClick();
            invButtonP.PerformClick();
            invButtonM.PerformClick();
            invButtonD.PerformClick();
            invButtonF.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Products");
            IMongoCollection<Product> records = pDatabase.GetCollection<Product>("productList");

            var recordsUpdate = Builders<Product>.Update.Set
                (p => p.productQuantity, productQuantityTB.Text).Set
                (p => p.productCost, productCostTB.Text).Set
                (p => p.productRetail, productRetailTB.Text).Set
                (p => p.productSupplier, productSupplierTB.Text).Set
                (p => p.productCategory, productlistCategory.GetItemText(productlistCategory.SelectedItem).ToString()).Set
                (p => p.productDate, productdateTimePicker.Value.ToShortDateString());
            records.UpdateOne(s => s.Id == ObjectId.Parse(productIdTB.Text), recordsUpdate);

            invButtonS.PerformClick();
            invButtonP.PerformClick();
            invButtonM.PerformClick();
            invButtonD.PerformClick();
            invButtonF.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Products");
            IMongoCollection<Product> records = pDatabase.GetCollection<Product>("productList");

            records.DeleteOne(p => p.Id == ObjectId.Parse(productIdTB.Text));
            invButtonS.PerformClick();
            invButtonP.PerformClick();
            invButtonM.PerformClick();
            invButtonD.PerformClick();
            invButtonF.PerformClick();
        }

        private void invSweetsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invSweetsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = invSweetsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productQuantityTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCostTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productRetailTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            productSupplierTB.Text = invSweetsDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            productlistCategory.Text = invSweetsDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            productdateTimePicker.Text = invSweetsDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void invButtonS_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Sweets";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            invSweetsDV.DataSource = filtered;
            invSweetsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            productIdTB.Text = invSweetsDV.Rows[0].Cells[0].Value.ToString();
            productNameTB.Text = invSweetsDV.Rows[0].Cells[1].Value.ToString();
            productQuantityTB.Text = invSweetsDV.Rows[0].Cells[2].Value.ToString();
            productCostTB.Text = invSweetsDV.Rows[0].Cells[3].Value.ToString();
            productRetailTB.Text = invSweetsDV.Rows[0].Cells[4].Value.ToString();
            productSupplierTB.Text = invSweetsDV.Rows[0].Cells[5].Value.ToString();
            productlistCategory.Text = invSweetsDV.Rows[0].Cells[6].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invSweetsDV.Rows[0].Cells[7].Value.ToString());
        }

        private void invPastryDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invPastryDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = invPastryDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = invPastryDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = invPastryDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productQuantityTB.Text = invPastryDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCostTB.Text = invPastryDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productRetailTB.Text = invPastryDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            productSupplierTB.Text = invPastryDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            productlistCategory.Text = invPastryDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            productdateTimePicker.Text = invPastryDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void invButtonP_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Pastry";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            invPastryDV.DataSource = filtered;
            invPastryDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            productIdTB.Text = invPastryDV.Rows[0].Cells[0].Value.ToString();
            productNameTB.Text = invPastryDV.Rows[0].Cells[1].Value.ToString();
            productQuantityTB.Text = invPastryDV.Rows[0].Cells[2].Value.ToString();
            productCostTB.Text = invPastryDV.Rows[0].Cells[3].Value.ToString();
            productRetailTB.Text = invPastryDV.Rows[0].Cells[4].Value.ToString();
            productSupplierTB.Text = invPastryDV.Rows[0].Cells[5].Value.ToString();
            productlistCategory.Text = invPastryDV.Rows[0].Cells[6].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invPastryDV.Rows[0].Cells[7].Value.ToString());
        }

        private void invMeatsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invMeatsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = invMeatsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productQuantityTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCostTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productRetailTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            productSupplierTB.Text = invMeatsDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            productlistCategory.Text = invMeatsDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            productdateTimePicker.Text = invMeatsDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void invButtonM_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Meats";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            invMeatsDV.DataSource = filtered;
            invMeatsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            productIdTB.Text = invMeatsDV.Rows[0].Cells[0].Value.ToString();
            productNameTB.Text = invMeatsDV.Rows[0].Cells[1].Value.ToString();
            productQuantityTB.Text = invMeatsDV.Rows[0].Cells[2].Value.ToString();
            productCostTB.Text = invMeatsDV.Rows[0].Cells[3].Value.ToString();
            productRetailTB.Text = invMeatsDV.Rows[0].Cells[4].Value.ToString();
            productSupplierTB.Text = invMeatsDV.Rows[0].Cells[5].Value.ToString();
            productlistCategory.Text = invMeatsDV.Rows[0].Cells[6].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invMeatsDV.Rows[0].Cells[7].Value.ToString());
        }

        private void invDrinksDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invDrinksDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = invDrinksDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productQuantityTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCostTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productRetailTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            productSupplierTB.Text = invDrinksDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            productlistCategory.Text = invDrinksDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            productdateTimePicker.Text = invDrinksDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void invButtonD_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Drinks";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            invDrinksDV.DataSource = filtered;
            invDrinksDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            productIdTB.Text = invDrinksDV.Rows[0].Cells[0].Value.ToString();
            productNameTB.Text = invDrinksDV.Rows[0].Cells[1].Value.ToString();
            productQuantityTB.Text = invDrinksDV.Rows[0].Cells[2].Value.ToString();
            productCostTB.Text = invDrinksDV.Rows[0].Cells[3].Value.ToString();
            productRetailTB.Text = invDrinksDV.Rows[0].Cells[4].Value.ToString();
            productSupplierTB.Text = invDrinksDV.Rows[0].Cells[5].Value.ToString();
            productlistCategory.Text = invDrinksDV.Rows[0].Cells[6].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invDrinksDV.Rows[0].Cells[7].Value.ToString());
        }

        private void invFruitsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invFruitsDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = invFruitsDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            productQuantityTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            productCostTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            productRetailTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            productSupplierTB.Text = invFruitsDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            productlistCategory.Text = invFruitsDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            productdateTimePicker.Text = invFruitsDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void invButtonF_Click(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Products");
            var records = pDatabase.checkRecords<Product>("productList");
            var pCategory = "Fruits";
            List<Product> filtered = records.Where(x => x.productCategory == pCategory).ToList();
            invFruitsDV.DataSource = filtered;
            invFruitsDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            productIdTB.Text = invFruitsDV.Rows[0].Cells[0].Value.ToString();
            productNameTB.Text = invFruitsDV.Rows[0].Cells[1].Value.ToString();
            productQuantityTB.Text = invFruitsDV.Rows[0].Cells[2].Value.ToString();
            productCostTB.Text = invFruitsDV.Rows[0].Cells[3].Value.ToString();
            productRetailTB.Text = invFruitsDV.Rows[0].Cells[4].Value.ToString();
            productSupplierTB.Text = invFruitsDV.Rows[0].Cells[5].Value.ToString();
            productlistCategory.Text = invFruitsDV.Rows[0].Cells[6].Value.ToString();
            productdateTimePicker.Value = Convert.ToDateTime(invFruitsDV.Rows[0].Cells[7].Value.ToString());
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invSweetsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invSweetsDV.Columns["Id"].Visible = false;
        }

        private void invPastryDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invPastryDV.Columns["Id"].Visible = false;
        }

        private void invMeatsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invMeatsDV.Columns["Id"].Visible = false;
        }

        private void invDrinksDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invDrinksDV.Columns["Id"].Visible = false;
        }

        private void invFruitsDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.invFruitsDV.Columns["Id"].Visible = false;
        }

        private void productQuantityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            accessPanel formAP = new accessPanel();
            formAP.ShowDialog();
            this.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventoryIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
