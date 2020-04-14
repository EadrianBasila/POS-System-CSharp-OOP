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
            LoginWindow formLW = new LoginWindow();
            formLW.ShowDialog();
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
            this.Hide();
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

        private void exportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];


            if (invTabs.SelectedTab.Name == "tabSweets")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Sweets";
                invButtonS.PerformClick();

                for (int i = 1; i < invSweetsDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invSweetsDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invSweetsDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invSweetsDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invSweetsDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsSweets-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (invTabs.SelectedTab.Name == "tabPastry")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Pastry";
                invButtonP.PerformClick();

                for (int i = 1; i < invPastryDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invPastryDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invPastryDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invPastryDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invPastryDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsPastry-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (invTabs.SelectedTab.Name == "tabMeats")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Meats";
                invButtonM.PerformClick();

                for (int i = 1; i < invMeatsDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invMeatsDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invMeatsDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invMeatsDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invMeatsDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsMeats-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (invTabs.SelectedTab.Name == "tabDrinks")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Sweets";
                invButtonD.PerformClick();

                for (int i = 1; i < invDrinksDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invDrinksDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invDrinksDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invDrinksDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invDrinksDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsDrinks-Inventory";
                saveFileDialog.DefaultExt = ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                }
                app.Quit();

            }

            else if (invTabs.SelectedTab.Name == "tabFruits")
            {
                worksheet = workbook.ActiveSheet; worksheet.Name = "Inventory Fruits";
                invButtonF.PerformClick();

                for (int i = 1; i < invFruitsDV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[i, 1] = invFruitsDV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < invFruitsDV.Rows.Count; i++)
                {
                    for (int j = 0; j < invFruitsDV.Columns.Count; j++)
                        worksheet.Cells[i + 2, j + 1] = invFruitsDV.Rows[i].Cells[j].Value.ToString();

                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RecordsFruits-Inventory";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            productIdTB.Text = "";
            productNameTB.Text = "";
            productQuantityTB.Text = "";
            productCostTB.Text = "";
            productRetailTB.Text = "";
            productSupplierTB.Text = "";
            productlistCategory.Text = "";            
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
