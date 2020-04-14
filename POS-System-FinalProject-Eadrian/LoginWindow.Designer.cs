namespace POSSystemOOPFinals
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lwdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adminLogin = new System.Windows.Forms.RadioButton();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.closeWindow = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("dark forest", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(94, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juan in a Million";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("dark forest", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(102, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sari-Sari Store";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lwdateTimePicker);
            this.panel1.Controls.Add(this.adminLogin);
            this.panel1.Controls.Add(this.loginUsername);
            this.panel1.Controls.Add(this.loginPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(464, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 356);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lwdateTimePicker
            // 
            this.lwdateTimePicker.CalendarFont = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwdateTimePicker.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lwdateTimePicker.Location = new System.Drawing.Point(229, 3);
            this.lwdateTimePicker.Name = "lwdateTimePicker";
            this.lwdateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lwdateTimePicker.RightToLeftLayout = true;
            this.lwdateTimePicker.Size = new System.Drawing.Size(93, 25);
            this.lwdateTimePicker.TabIndex = 13;
            // 
            // adminLogin
            // 
            this.adminLogin.AutoSize = true;
            this.adminLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.adminLogin.Location = new System.Drawing.Point(87, 274);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(160, 22);
            this.adminLogin.TabIndex = 12;
            this.adminLogin.TabStop = true;
            this.adminLogin.Text = "Administrator Login";
            this.toolTip1.SetToolTip(this.adminLogin, "[?] Mark this if your trying to login as an administrator");
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // loginUsername
            // 
            this.loginUsername.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ForeColor = System.Drawing.Color.White;
            this.loginUsername.Location = new System.Drawing.Point(36, 175);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(253, 27);
            this.loginUsername.TabIndex = 7;
            this.loginUsername.TextChanged += new System.EventHandler(this.loginUsername_TextChanged);
            this.loginUsername.Enter += new System.EventHandler(this.loginUsername_Enter);
            this.loginUsername.Leave += new System.EventHandler(this.loginUsername_Leave);
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.ForeColor = System.Drawing.Color.White;
            this.loginPassword.Location = new System.Drawing.Point(36, 235);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(253, 27);
            this.loginPassword.TabIndex = 8;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            this.loginPassword.Enter += new System.EventHandler(this.loginPassword_Enter);
            this.loginPassword.Leave += new System.EventHandler(this.loginPassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(32, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.PaleGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginButton.Location = new System.Drawing.Point(108, 307);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 33);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "      Login     ";
            this.loginButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(108, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 96);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 72);
            this.label6.TabIndex = 8;
            this.label6.Text = "\"Best Sari-Sari Store 2020\" \r\n-Philippine Sari-Sari Organization.  ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(158, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 109);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(40, 313);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 58);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(40, 377);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 58);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(108, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 48);
            this.label7.TabIndex = 10;
            this.label7.Text = "\"Malinis, Pwedeng Tambayan tuwing \r\nmay Inuman!\"  -Mang Tane\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(108, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 48);
            this.label8.TabIndex = 11;
            this.label8.Text = "\"Mabait Magpautang hehe\"\r\n-Aling Flora\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeWindow.BackgroundImage")));
            this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeWindow.Location = new System.Drawing.Point(748, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(40, 40);
            this.closeWindow.TabIndex = 12;
            this.closeWindow.TabStop = false;
            this.closeWindow.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginButton;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox closeWindow;
        private System.Windows.Forms.RadioButton adminLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker lwdateTimePicker;
    }
}