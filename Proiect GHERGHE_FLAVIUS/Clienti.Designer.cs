namespace Proiect_GHERGHE_FLAVIUS
{
    partial class Clienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clienti));
            this.StergeBtn = new System.Windows.Forms.Button();
            this.EditeazaBtn = new System.Windows.Forms.Button();
            this.SalveazaBtn = new System.Windows.Forms.Button();
            this.GenTb = new System.Windows.Forms.ComboBox();
            this.AdresaTb = new System.Windows.Forms.TextBox();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.NumeClientTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientiAfisare = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiAfisare)).BeginInit();
            this.SuspendLayout();
            // 
            // StergeBtn
            // 
            this.StergeBtn.BackColor = System.Drawing.Color.Red;
            this.StergeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StergeBtn.Location = new System.Drawing.Point(95, 504);
            this.StergeBtn.Name = "StergeBtn";
            this.StergeBtn.Size = new System.Drawing.Size(75, 23);
            this.StergeBtn.TabIndex = 33;
            this.StergeBtn.Text = "Sterge";
            this.StergeBtn.UseVisualStyleBackColor = false;
            this.StergeBtn.Click += new System.EventHandler(this.StergeBtn_Click);
            // 
            // EditeazaBtn
            // 
            this.EditeazaBtn.BackColor = System.Drawing.Color.Gray;
            this.EditeazaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditeazaBtn.Location = new System.Drawing.Point(150, 471);
            this.EditeazaBtn.Name = "EditeazaBtn";
            this.EditeazaBtn.Size = new System.Drawing.Size(75, 23);
            this.EditeazaBtn.TabIndex = 32;
            this.EditeazaBtn.Text = "Editeaza";
            this.EditeazaBtn.UseVisualStyleBackColor = false;
            this.EditeazaBtn.Click += new System.EventHandler(this.EditeazaBtn_Click);
            // 
            // SalveazaBtn
            // 
            this.SalveazaBtn.BackColor = System.Drawing.Color.Green;
            this.SalveazaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalveazaBtn.Location = new System.Drawing.Point(42, 471);
            this.SalveazaBtn.Name = "SalveazaBtn";
            this.SalveazaBtn.Size = new System.Drawing.Size(75, 23);
            this.SalveazaBtn.TabIndex = 31;
            this.SalveazaBtn.Text = "Salveaza";
            this.SalveazaBtn.UseVisualStyleBackColor = false;
            this.SalveazaBtn.Click += new System.EventHandler(this.SalveazaBtn_Click);
            // 
            // GenTb
            // 
            this.GenTb.FormattingEnabled = true;
            this.GenTb.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.GenTb.Location = new System.Drawing.Point(42, 319);
            this.GenTb.Name = "GenTb";
            this.GenTb.Size = new System.Drawing.Size(181, 23);
            this.GenTb.TabIndex = 29;
            this.GenTb.Text = "Gen";
            // 
            // AdresaTb
            // 
            this.AdresaTb.Location = new System.Drawing.Point(42, 397);
            this.AdresaTb.Multiline = true;
            this.AdresaTb.Name = "AdresaTb";
            this.AdresaTb.PlaceholderText = "Adresa";
            this.AdresaTb.Size = new System.Drawing.Size(181, 53);
            this.AdresaTb.TabIndex = 27;
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(42, 357);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.PlaceholderText = "Telefon";
            this.TelefonTb.Size = new System.Drawing.Size(181, 23);
            this.TelefonTb.TabIndex = 26;
            // 
            // NumeClientTb
            // 
            this.NumeClientTb.Location = new System.Drawing.Point(42, 280);
            this.NumeClientTb.Name = "NumeClientTb";
            this.NumeClientTb.PlaceholderText = "NumeClient";
            this.NumeClientTb.Size = new System.Drawing.Size(181, 23);
            this.NumeClientTb.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(46, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gestioneaza clientii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(726, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Clienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "SISTEM GESTIONARE STOC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 152);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 42);
            this.panel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Stoc";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 30);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(492, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dashboard";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(412, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Comenzi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(326, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Furnizori";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(247, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Clienti";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(164, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Categorii";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(469, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 30);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(390, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 30);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(299, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 30);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(224, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 27);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(137, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(82, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Produse";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEM GESTIONARE STOC";
            // 
            // ClientiAfisare
            // 
            this.ClientiAfisare.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.ClientiAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientiAfisare.Location = new System.Drawing.Point(299, 80);
            this.ClientiAfisare.Name = "ClientiAfisare";
            this.ClientiAfisare.RowTemplate.Height = 25;
            this.ClientiAfisare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientiAfisare.Size = new System.Drawing.Size(920, 501);
            this.ClientiAfisare.TabIndex = 34;
            this.ClientiAfisare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientiAfisare_CellContentClick);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 621);
            this.Controls.Add(this.ClientiAfisare);
            this.Controls.Add(this.StergeBtn);
            this.Controls.Add(this.EditeazaBtn);
            this.Controls.Add(this.SalveazaBtn);
            this.Controls.Add(this.GenTb);
            this.Controls.Add(this.AdresaTb);
            this.Controls.Add(this.TelefonTb);
            this.Controls.Add(this.NumeClientTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiAfisare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StergeBtn;
        private Button EditeazaBtn;
        private Button SalveazaBtn;
        private ComboBox GenTb;
        private TextBox AdresaTb;
        private TextBox TelefonTb;
        private TextBox NumeClientTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox8;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView ClientiAfisare;
    }
}