using MongoDB.Driver;
using POS_System_FinalProject_Eadrian;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace POSSystemOOPFinals
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

      

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void posIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPOS formSalesP = new SalesPOS();
            formSalesP.ShowDialog();
            this.Close();
        }

        private void inventoryIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory formInventory = new Inventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportIcon_Click(object sender, EventArgs e)
        {

        }

        public string eValue;
        public void employeeValue(string p)
        {
            eValue = p.ToString();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = eValue.ToString();
            textBox2.Text = "0";
            
        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("EmployeeShifts");
            var records = pDatabase.checkRecords<Workshift>("workShifts");
            var pCategory = textBox1.Text;
            List<Workshift> filtered = records.Where(x => x.employeeUsername == pCategory).ToList();
            dataGridView1.DataSource = filtered;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            foreach (var record in filtered) 
            {
                var salary = int.Parse(textBox2.Text) + 500;
                textBox2.Text = salary.ToString();
            }
        }

      
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

     

        private void dbgrossLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            
            this.Hide();
            accessPanel formAP = new accessPanel();
            formAP.ShowDialog();
            this.Close();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["employeeUsername"].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            IMongoDatabase pDatabase = client.GetDatabase("Workforce");
            IMongoCollection<Workforce> records = pDatabase.GetCollection<Workforce>("Peeps");

            var recordsUpdate = Builders<Workforce>.Update.Set
                (p => p.employeeSalary, textBox2.Text);
            records.UpdateOne(s => s.loginUsername == textBox1.Text, recordsUpdate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            recordDatabase pDatabase = new recordDatabase("Purchase");
            var records = pDatabase.checkRecords<purchaseRegistry>("purchaseRecords");
            foreach (var record in records) 
            { 
            
            }

            dbSalesDV.DataSource = records;
            dbSalesDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            int totalCost = dbSalesDV.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[2].Value));
            tcisTB.Text = totalCost.ToString();

            int totalRetail = dbSalesDV.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));
            traTB.Text = totalRetail.ToString();

            int grossMargin = (totalCost - totalRetail);
            textBox3.Text = grossMargin.ToString();

            decimal profit = grossMargin/totalCost;
            textBox4.Text = profit.ToString("N2");
            //MessageBox.Show(profitPercentage.ToString());
            //var profitPercentageB = (profitPercentageA * 100).ToString();
            //textBox4.Text = float.Parse(profitPercentageB, CultureInfo.InvariantCulture).ToString();
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dbSalesDV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dbSalesDV.Columns["Id"].Visible = false;
            this.dbSalesDV.Columns["posPurchaseDate"].Visible = false;
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

