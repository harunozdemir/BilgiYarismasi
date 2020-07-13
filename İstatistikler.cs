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
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmIstatistikler_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmKategori frm = new frmKategori();
            frm.Show();
        }

        public void istatistikler()
        {
            String ConStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(ConStr);
            OleDbCommand cmd = new OleDbCommand();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM İstatistikler";

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                lblMatDogru.Text = dr["mat_dogru_sayisi"].ToString();
                lblMatYanlis.Text = dr["mat_yanlis_sayisi"].ToString();
                
                lblSporDogru.Text = dr["spor_dogru_sayisi"].ToString();
                lblSporYanlis.Text = dr["spor_yanlis_sayisi"].ToString();
                
                lblGenelKDogru.Text = dr["gKultur_dogru_sayisi"].ToString();
                lblGenelKYanlis.Text = dr["gKultur_yanlis_sayisi"].ToString();

                lblYemekDogru.Text = dr["yemek_dogru_sayisi"].ToString();
                lblYemekYanlis.Text = dr["yemek_yanlis_sayisi"].ToString();

                lblToplamDogru.Text = dr["top_dogru_sayisi"].ToString();
                lblToplamYanlis.Text = dr["top_yanlis_sayisi"].ToString();

                
                lblPuanMat.Text = (int.Parse(lblMatDogru.Text) - int.Parse(lblMatYanlis.Text)).ToString();
                lblPuanSpor.Text = (int.Parse(lblSporDogru.Text) - int.Parse(lblSporYanlis.Text)).ToString();
                lblGenelKPuan.Text = (int.Parse(lblGenelKDogru.Text) - int.Parse(lblGenelKYanlis.Text)).ToString();
                lblYemekPuan.Text = (int.Parse(lblYemekDogru.Text) - int.Parse(lblYemekYanlis.Text)).ToString();

                lblTopPuan.Text = dr["top_puan"].ToString();


            }

            dt.Clear();
        }
        private void frmIstatistikler_Load(object sender, EventArgs e)
        {
          istatistikler();

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
