namespace bilg_oyun
{
    partial class frmSpor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpor));
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.pbIleri = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dogruSayi = new System.Windows.Forms.Label();
            this.yanlissayi = new System.Windows.Forms.Label();
            this.lblDogruSayi = new System.Windows.Forms.Label();
            this.lblYanlisSayi = new System.Windows.Forms.Label();
            this.lblPuanSpor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbBitir = new System.Windows.Forms.PictureBox();
            this.lblDogruYanlis = new System.Windows.Forms.Label();
            this.pbDogru = new System.Windows.Forms.PictureBox();
            this.pbYanlis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIleri)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYanlis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoru.Location = new System.Drawing.Point(12, 12);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(437, 54);
            this.txtSoru.TabIndex = 0;
            this.txtSoru.Text = "Spor Soruları";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA.Location = new System.Drawing.Point(14, 83);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(107, 21);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC.Location = new System.Drawing.Point(14, 129);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(107, 21);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton2";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB.Location = new System.Drawing.Point(223, 83);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(107, 21);
            this.rbB.TabIndex = 3;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton3";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD.Location = new System.Drawing.Point(223, 129);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(107, 21);
            this.rbD.TabIndex = 4;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // pbIleri
            // 
            this.pbIleri.BackColor = System.Drawing.Color.Transparent;
            this.pbIleri.Image = ((System.Drawing.Image)(resources.GetObject("pbIleri.Image")));
            this.pbIleri.Location = new System.Drawing.Point(338, 248);
            this.pbIleri.Name = "pbIleri";
            this.pbIleri.Size = new System.Drawing.Size(109, 48);
            this.pbIleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIleri.TabIndex = 5;
            this.pbIleri.TabStop = false;
            this.pbIleri.Click += new System.EventHandler(this.pbIleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "PUAN: ";
            // 
            // dogruSayi
            // 
            this.dogruSayi.AutoSize = true;
            this.dogruSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogruSayi.ForeColor = System.Drawing.Color.Lime;
            this.dogruSayi.Location = new System.Drawing.Point(13, 28);
            this.dogruSayi.Name = "dogruSayi";
            this.dogruSayi.Size = new System.Drawing.Size(96, 17);
            this.dogruSayi.TabIndex = 7;
            this.dogruSayi.Text = "Dogru Sayısı: ";
            // 
            // yanlissayi
            // 
            this.yanlissayi.AutoSize = true;
            this.yanlissayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yanlissayi.ForeColor = System.Drawing.Color.Red;
            this.yanlissayi.Location = new System.Drawing.Point(13, 63);
            this.yanlissayi.Name = "yanlissayi";
            this.yanlissayi.Size = new System.Drawing.Size(95, 17);
            this.yanlissayi.TabIndex = 8;
            this.yanlissayi.Text = "Yanlış Sayısı: ";
            // 
            // lblDogruSayi
            // 
            this.lblDogruSayi.AutoSize = true;
            this.lblDogruSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogruSayi.ForeColor = System.Drawing.Color.Lime;
            this.lblDogruSayi.Location = new System.Drawing.Point(107, 28);
            this.lblDogruSayi.Name = "lblDogruSayi";
            this.lblDogruSayi.Size = new System.Drawing.Size(16, 17);
            this.lblDogruSayi.TabIndex = 9;
            this.lblDogruSayi.Text = "0";
            // 
            // lblYanlisSayi
            // 
            this.lblYanlisSayi.AutoSize = true;
            this.lblYanlisSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYanlisSayi.ForeColor = System.Drawing.Color.Red;
            this.lblYanlisSayi.Location = new System.Drawing.Point(107, 62);
            this.lblYanlisSayi.Name = "lblYanlisSayi";
            this.lblYanlisSayi.Size = new System.Drawing.Size(16, 17);
            this.lblYanlisSayi.TabIndex = 10;
            this.lblYanlisSayi.Text = "0";
            // 
            // lblPuanSpor
            // 
            this.lblPuanSpor.AutoSize = true;
            this.lblPuanSpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuanSpor.Location = new System.Drawing.Point(206, 42);
            this.lblPuanSpor.Name = "lblPuanSpor";
            this.lblPuanSpor.Size = new System.Drawing.Size(18, 20);
            this.lblPuanSpor.TabIndex = 11;
            this.lblPuanSpor.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogruSayi);
            this.groupBox1.Controls.Add(this.lblPuanSpor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblYanlisSayi);
            this.groupBox1.Controls.Add(this.yanlissayi);
            this.groupBox1.Controls.Add(this.lblDogruSayi);
            this.groupBox1.Location = new System.Drawing.Point(14, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PUANLAMA";
            // 
            // pbBitir
            // 
            this.pbBitir.Image = ((System.Drawing.Image)(resources.GetObject("pbBitir.Image")));
            this.pbBitir.Location = new System.Drawing.Point(338, 178);
            this.pbBitir.Name = "pbBitir";
            this.pbBitir.Size = new System.Drawing.Size(111, 51);
            this.pbBitir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBitir.TabIndex = 13;
            this.pbBitir.TabStop = false;
            this.pbBitir.Click += new System.EventHandler(this.pbBitir_Click);
            // 
            // lblDogruYanlis
            // 
            this.lblDogruYanlis.AutoSize = true;
            this.lblDogruYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogruYanlis.Location = new System.Drawing.Point(375, 86);
            this.lblDogruYanlis.Name = "lblDogruYanlis";
            this.lblDogruYanlis.Size = new System.Drawing.Size(0, 22);
            this.lblDogruYanlis.TabIndex = 14;
            // 
            // pbDogru
            // 
            this.pbDogru.Image = ((System.Drawing.Image)(resources.GetObject("pbDogru.Image")));
            this.pbDogru.Location = new System.Drawing.Point(393, 111);
            this.pbDogru.Name = "pbDogru";
            this.pbDogru.Size = new System.Drawing.Size(20, 24);
            this.pbDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDogru.TabIndex = 15;
            this.pbDogru.TabStop = false;
            // 
            // pbYanlis
            // 
            this.pbYanlis.Image = ((System.Drawing.Image)(resources.GetObject("pbYanlis.Image")));
            this.pbYanlis.Location = new System.Drawing.Point(393, 111);
            this.pbYanlis.Name = "pbYanlis";
            this.pbYanlis.Size = new System.Drawing.Size(20, 24);
            this.pbYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYanlis.TabIndex = 16;
            this.pbYanlis.TabStop = false;
            // 
            // frmSpor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 308);
            this.Controls.Add(this.pbYanlis);
            this.Controls.Add(this.pbDogru);
            this.Controls.Add(this.lblDogruYanlis);
            this.Controls.Add(this.pbBitir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbIleri);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.txtSoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSpor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Soruları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSpor_FormClosing);
            this.Load += new System.EventHandler(this.frmSpor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIleri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYanlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.PictureBox pbIleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dogruSayi;
        private System.Windows.Forms.Label yanlissayi;
        private System.Windows.Forms.Label lblDogruSayi;
        private System.Windows.Forms.Label lblYanlisSayi;
        private System.Windows.Forms.Label lblPuanSpor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBitir;
        private System.Windows.Forms.Label lblDogruYanlis;
        private System.Windows.Forms.PictureBox pbDogru;
        private System.Windows.Forms.PictureBox pbYanlis;
    }
}