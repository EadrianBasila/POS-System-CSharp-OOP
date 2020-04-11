namespace POSSystemOOPFinals
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ScreenTitle = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardIcon = new System.Windows.Forms.PictureBox();
            this.inventoryIcon = new System.Windows.Forms.PictureBox();
            this.posIcon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dbprofitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dbgrossLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cartesianChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posIcon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartesianChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netProfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.ScreenTitle);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(326, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 59);
            this.panel8.TabIndex = 9;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Bebas Neue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1304, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 31);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ScreenTitle
            // 
            this.ScreenTitle.AutoSize = true;
            this.ScreenTitle.Font = new System.Drawing.Font("Bebas Neue", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTitle.ForeColor = System.Drawing.Color.White;
            this.ScreenTitle.Location = new System.Drawing.Point(3, -2);
            this.ScreenTitle.Name = "ScreenTitle";
            this.ScreenTitle.Size = new System.Drawing.Size(259, 76);
            this.ScreenTitle.TabIndex = 7;
            this.ScreenTitle.Text = "Dashboard";
            this.ScreenTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1572, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1634, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dashboardIcon);
            this.panel2.Controls.Add(this.inventoryIcon);
            this.panel2.Controls.Add(this.posIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 786);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(18, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 98);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(122, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 99);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.BackgroundImage")));
            this.dashboardIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardIcon.Location = new System.Drawing.Point(18, 77);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(101, 98);
            this.dashboardIcon.TabIndex = 16;
            this.dashboardIcon.TabStop = false;
            this.dashboardIcon.Click += new System.EventHandler(this.dashboardIcon_Click);
            // 
            // inventoryIcon
            // 
            this.inventoryIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryIcon.BackgroundImage")));
            this.inventoryIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryIcon.Location = new System.Drawing.Point(18, 320);
            this.inventoryIcon.Name = "inventoryIcon";
            this.inventoryIcon.Size = new System.Drawing.Size(101, 98);
            this.inventoryIcon.TabIndex = 15;
            this.inventoryIcon.TabStop = false;
            this.inventoryIcon.Click += new System.EventHandler(this.inventoryIcon_Click);
            // 
            // posIcon
            // 
            this.posIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("posIcon.BackgroundImage")));
            this.posIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.posIcon.Location = new System.Drawing.Point(18, 198);
            this.posIcon.Name = "posIcon";
            this.posIcon.Size = new System.Drawing.Size(101, 98);
            this.posIcon.TabIndex = 13;
            this.posIcon.TabStop = false;
            this.posIcon.Click += new System.EventHandler(this.posIcon_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.cartesianChart1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(172, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 435);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1026, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("dark forest", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 77);
            this.label1.TabIndex = 8;
            this.label1.Text = "NET Profit";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(539, 374);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 0);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.dbprofitLabel);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(172, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 270);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // dbprofitLabel
            // 
            this.dbprofitLabel.AutoSize = true;
            this.dbprofitLabel.Font = new System.Drawing.Font("Bebas Neue", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbprofitLabel.ForeColor = System.Drawing.Color.White;
            this.dbprofitLabel.Location = new System.Drawing.Point(52, 73);
            this.dbprofitLabel.Name = "dbprofitLabel";
            this.dbprofitLabel.Size = new System.Drawing.Size(283, 180);
            this.dbprofitLabel.TabIndex = 10;
            this.dbprofitLabel.Text = "69%";
            this.dbprofitLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("dark forest", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "PROFIT Percentage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.dbgrossLabel);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(579, 551);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(661, 270);
            this.panel7.TabIndex = 6;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint_1);
            // 
            // dbgrossLabel
            // 
            this.dbgrossLabel.AutoSize = true;
            this.dbgrossLabel.Font = new System.Drawing.Font("Bebas Neue", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgrossLabel.ForeColor = System.Drawing.Color.White;
            this.dbgrossLabel.Location = new System.Drawing.Point(75, 58);
            this.dbgrossLabel.Name = "dbgrossLabel";
            this.dbgrossLabel.Size = new System.Drawing.Size(375, 180);
            this.dbgrossLabel.TabIndex = 11;
            this.dbgrossLabel.Text = "$1000";
            this.dbgrossLabel.Click += new System.EventHandler(this.dbgrossLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("dark forest", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 49);
            this.label3.TabIndex = 10;
            this.label3.Text = "GROSS Margin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.pieChart1);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(1256, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(418, 720);
            this.panel9.TabIndex = 9;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("dark forest", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 61);
            this.label4.TabIndex = 8;
            this.label4.Text = "STORE STOCKS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cartesianChartBindingSource
            // 
            this.cartesianChartBindingSource.DataSource = typeof(LiveCharts.WinForms.CartesianChart);
            this.cartesianChartBindingSource.CurrentChanged += new System.EventHandler(this.cartesianChartBindingSource_CurrentChanged);
            // 
            // netProfitBindingSource
            // 
            this.netProfitBindingSource.DataSource = typeof(POSSystemOOPFinals.netProfit);
            this.netProfitBindingSource.CurrentChanged += new System.EventHandler(this.netProfitBindingSource_CurrentChanged);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(13, 91);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1039, 328);
            this.cartesianChart1.TabIndex = 9;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(31, 76);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(358, 383);
            this.pieChart1.TabIndex = 9;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1700, 860);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartesianChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netProfitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label ScreenTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dbprofitLabel;
        private System.Windows.Forms.Label dbgrossLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dashboardIcon;
        private System.Windows.Forms.PictureBox inventoryIcon;
        private System.Windows.Forms.PictureBox posIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.BindingSource cartesianChartBindingSource;
        private System.Windows.Forms.BindingSource netProfitBindingSource;
    }
}

