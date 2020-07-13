namespace bilg_oyun
{
    partial class frmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategori));
            this.pbAnaMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYemek = new System.Windows.Forms.Button();
            this.btnSpor = new System.Windows.Forms.Button();
            this.btnMatematik = new System.Windows.Forms.Button();
            this.btnGenelKultur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnaMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnaMenu
            // 
            this.pbAnaMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbAnaMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbAnaMenu.Image")));
            this.pbAnaMenu.Location = new System.Drawing.Point(16, 230);
            this.pbAnaMenu.Name = "pbAnaMenu";
            this.pbAnaMenu.Size = new System.Drawing.Size(109, 48);
            this.pbAnaMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAnaMenu.TabIndex = 0;
            this.pbAnaMenu.TabStop = false;
            this.pbAnaMenu.Click += new System.EventHandler(this.pbAnaMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOPLAM PUANINIZ:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.Location = new System.Drawing.Point(149, 192);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 20);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnYemek
            // 
            this.btnYemek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYemek.ForeColor = System.Drawing.Color.White;
            this.btnYemek.Location = new System.Drawing.Point(29, 18);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(96, 41);
            this.btnYemek.TabIndex = 8;
            this.btnYemek.Text = "5-9 yaş";
            this.btnYemek.UseVisualStyleBackColor = false;
            this.btnYemek.Click += new System.EventHandler(this.btnYemek_Click);
            // 
            // btnSpor
            // 
            this.btnSpor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSpor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpor.ForeColor = System.Drawing.Color.White;
            this.btnSpor.Location = new System.Drawing.Point(187, 18);
            this.btnSpor.Name = "btnSpor";
            this.btnSpor.Size = new System.Drawing.Size(96, 41);
            this.btnSpor.TabIndex = 9;
            this.btnSpor.Text = "9-15 yaş";
            this.btnSpor.UseVisualStyleBackColor = false;
            this.btnSpor.Click += new System.EventHandler(this.btnSpor_Click);
            // 
            // btnMatematik
            // 
            this.btnMatematik.BackColor = System.Drawing.Color.Green;
            this.btnMatematik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMatematik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatematik.ForeColor = System.Drawing.Color.White;
            this.btnMatematik.Location = new System.Drawing.Point(29, 88);
            this.btnMatematik.Name = "btnMatematik";
            this.btnMatematik.Size = new System.Drawing.Size(96, 41);
            this.btnMatematik.TabIndex = 10;
            this.btnMatematik.Text = "15-18 yaş";
            this.btnMatematik.UseVisualStyleBackColor = false;
            this.btnMatematik.Click += new System.EventHandler(this.btnMatematik_Click);
            // 
            // btnGenelKultur
            // 
            this.btnGenelKultur.BackColor = System.Drawing.Color.Gold;
            this.btnGenelKultur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenelKultur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelKultur.ForeColor = System.Drawing.Color.White;
            this.btnGenelKultur.Location = new System.Drawing.Point(187, 88);
            this.btnGenelKultur.Name = "btnGenelKultur";
            this.btnGenelKultur.Size = new System.Drawing.Size(96, 41);
            this.btnGenelKultur.TabIndex = 11;
            this.btnGenelKultur.Text = "18-24 yaş";
            this.btnGenelKultur.UseVisualStyleBackColor = false;
            this.btnGenelKultur.Click += new System.EventHandler(this.btnGenelKultur_Click);
            // 
            // frmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 292);
            this.Controls.Add(this.btnGenelKultur);
            this.Controls.Add(this.btnMatematik);
            this.Controls.Add(this.btnSpor);
            this.Controls.Add(this.btnYemek);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAnaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKategori_FormClosing);
            this.Load += new System.EventHandler(this.frmKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnaMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnaMenu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYemek;
        private System.Windows.Forms.Button btnSpor;
        private System.Windows.Forms.Button btnMatematik;
        private System.Windows.Forms.Button btnGenelKultur;
    }
}