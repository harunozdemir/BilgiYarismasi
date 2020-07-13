namespace bilg_oyun
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbOyna = new System.Windows.Forms.PictureBox();
            this.pbNasılOynanir = new System.Windows.Forms.PictureBox();
            this.pbCikis = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNasılOynanir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOyna
            // 
            this.pbOyna.BackColor = System.Drawing.Color.Transparent;
            this.pbOyna.Image = ((System.Drawing.Image)(resources.GetObject("pbOyna.Image")));
            this.pbOyna.Location = new System.Drawing.Point(51, 125);
            this.pbOyna.Name = "pbOyna";
            this.pbOyna.Size = new System.Drawing.Size(113, 50);
            this.pbOyna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOyna.TabIndex = 0;
            this.pbOyna.TabStop = false;
            this.pbOyna.Click += new System.EventHandler(this.pbOyna_Click);
            // 
            // pbNasılOynanir
            // 
            this.pbNasılOynanir.BackColor = System.Drawing.Color.Transparent;
            this.pbNasılOynanir.Image = ((System.Drawing.Image)(resources.GetObject("pbNasılOynanir.Image")));
            this.pbNasılOynanir.Location = new System.Drawing.Point(51, 200);
            this.pbNasılOynanir.Name = "pbNasılOynanir";
            this.pbNasılOynanir.Size = new System.Drawing.Size(113, 50);
            this.pbNasılOynanir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNasılOynanir.TabIndex = 1;
            this.pbNasılOynanir.TabStop = false;
            this.pbNasılOynanir.Click += new System.EventHandler(this.pbNasılOynanir_Click);
            // 
            // pbCikis
            // 
            this.pbCikis.BackColor = System.Drawing.Color.Transparent;
            this.pbCikis.Image = ((System.Drawing.Image)(resources.GetObject("pbCikis.Image")));
            this.pbCikis.Location = new System.Drawing.Point(51, 272);
            this.pbCikis.Name = "pbCikis";
            this.pbCikis.Size = new System.Drawing.Size(113, 50);
            this.pbCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCikis.TabIndex = 2;
            this.pbCikis.TabStop = false;
            this.pbCikis.Click += new System.EventHandler(this.pbCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCikis);
            this.Controls.Add(this.pbNasılOynanir);
            this.Controls.Add(this.pbOyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİLGİ OYUN";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOyna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNasılOynanir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOyna;
        private System.Windows.Forms.PictureBox pbNasılOynanir;
        private System.Windows.Forms.PictureBox pbCikis;
        private System.Windows.Forms.PictureBox pictureBox1;




    }
}

