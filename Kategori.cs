using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bilg_oyun
{
    public partial class frmKategori : Form
    {
        
        public frmKategori()
        {
            InitializeComponent();
        }

        private void pbAnaMenu_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
            
        }

      
        private void frmKategori_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
            frmYemek frm = new frmYemek();
            this.Hide();
            frm.Show();
        }

        private void btnSpor_Click(object sender, EventArgs e)
        {
            frmSpor frm = new frmSpor();
            this.Hide();
            frm.Show();
        }

        private void btnMatematik_Click(object sender, EventArgs e)
        {
            Matematik frm = new Matematik();
            this.Hide();
            frm.Show();
        }

        private void btnGenelKultur_Click(object sender, EventArgs e)
        {
            Genel_Kültür frm = new Genel_Kültür();
            this.Hide();
            frm.Show();
            
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            puanGetir();
        }

        public void puanGetir()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            string puan = "SELECT top_puan FROM İstatistikler";
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(puan,con);

            try
            {
                lblPuan.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmIstatistikler frm = new frmIstatistikler();
            this.Hide();
            frm.Show();
        }

    
    }
}
