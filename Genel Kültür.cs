using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace bilg_oyun
{
    public partial class Genel_Kültür : Form
    {
        private String cevap;
        private int dogruSayisi, yanlisSayisi, netSayisi, sorulacakSoru = 1, soruSayi;
        public Genel_Kültür()
        {
            InitializeComponent();
        }

        private void Genel_Kültür_Load(object sender, EventArgs e)
        {
            pbDogru.Visible = false;
            pbYanlis.Visible = false;
            rbA.Select();
            if (rbA.Checked == true || rbB.Checked == true || rbC.Checked == true || rbD.Checked == true)
                pbIleri.Enabled = true;
            else
                pbIleri.Enabled = false;

            Sorusor(sorulacakSoru);
            cevap = cevapBul(sorulacakSoru);
        }

        public void Sorusor(int SoruNo)
        {
            String ConStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(ConStr);
            OleDbCommand cmd = new OleDbCommand();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Genel_Kultur WHERE soruNo =" + SoruNo;

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtSoru.Text = dr["soru"].ToString();
                rbA.Text = "A) " + " " + dr["cevapA"].ToString();
                rbB.Text = "B) " + " " + dr["cevapB"].ToString();
                rbC.Text = "C) " + " " + dr["cevapC"].ToString();
                rbD.Text = "D) " + " " + dr["cevapD"].ToString();

            }

            dt.Clear();
        }

        private string cevapBul(int Soruno)
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            String selectText = "SELECT dogruCevap FROM Genel_Kultur WHERE soruNo=" + Soruno;
            OleDbConnection con1 = new OleDbConnection(conStr);

            con1.Open();
            OleDbCommand cmd1 = new OleDbCommand(selectText, con1);
            try
            {
                cevap = cmd1.ExecuteScalar().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con1.Close();
            }
            return cevap;


        }

        public int soruSayisi()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            String selectText = "SELECT count(*) FROM Genel_Kultur";
            OleDbConnection con2 = new OleDbConnection(conStr);


            con2.Open();
            OleDbCommand cmd2 = new OleDbCommand(selectText, con2);
            try
            {
                soruSayi = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con2.Close();
            }
            return soruSayi;
        }

        public void cevapKontrol(string cevap)
        {
            if (rbA.Checked)
            {
                if (cevap.ToUpper() == "A")
                {
                    dogruSayisi += 1;
                    dogruYaz();
                }
                else
                {
                    yanlisSayisi += 1;
                    yanlisYaz();
                }
            }

            if (rbB.Checked)
            {
                if (cevap.ToUpper() == "B")
                {
                    dogruSayisi += 1;
                    dogruYaz();
                }
                else
                {
                    yanlisSayisi += 1;
                    yanlisYaz();
                }
            }

            if (rbC.Checked)
            {
                if (cevap.ToUpper() == "C")
                {
                    dogruSayisi += 1;
                    dogruYaz();
                }
                else
                {
                    yanlisSayisi += 1;
                    yanlisYaz();
                }
            }

            if (rbD.Checked)
            {
                if (cevap.ToUpper() == "D")
                {
                    dogruSayisi += 1;
                    dogruYaz();
                }
                else
                {
                    yanlisSayisi += 1;
                    yanlisYaz();
                }
            }

            netSayisi = (dogruSayisi - yanlisSayisi);

            lblDogruSayi.Text = dogruSayisi.ToString();
            lblYanlisSayi.Text = yanlisSayisi.ToString();
            lblPuanGenelKultur.Text = netSayisi.ToString();

        }
        private void dogruSes()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "alkis.wav"; // Çalmasini istediginiz ses dosyasinin yolu
            player.SoundLocation = path;
            player.Play();
        }
        private void yanlisSes()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "yanlis.wav"; // Çalmasini istediginiz ses dosyasinin yolu
            player.SoundLocation = path;
            player.Play();
        }
        private void dogruYaz()
        {
            lblDogruYanlis.Text = "DOĞRU";
            lblDogruYanlis.ForeColor = Color.Green;
            pbDogru.Visible = true;
            pbYanlis.Visible = false;
            dogruSes();
        }

        private void yanlisYaz()
        {
            lblDogruYanlis.Text = "YANLIŞ";
            lblDogruYanlis.ForeColor = Color.Red;
            pbDogru.Visible = false;
            pbYanlis.Visible = true;
            yanlisSes();
        }

        private void Genel_Kültür_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmKategori frm = new frmKategori();
            this.Hide();
            frm.Show();
            
        }

        private void pbIleri_Click(object sender, EventArgs e)
        {
            if (sorulacakSoru != soruSayisi() + 1)
            {
                String cevap = cevapBul(sorulacakSoru);
                cevapKontrol(cevap);
                sorulacakSoru += 1;
                Sorusor(sorulacakSoru);

            }
            else
            {
                MessageBox.Show("Yarışma sona erdi.Puanınız: " + lblPuanGenelKultur.Text.ToString(), "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            pbIleri.Enabled = true;
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            pbIleri.Enabled = true;
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            pbIleri.Enabled = true;
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            pbIleri.Enabled = true;
        }

        public void update_istatistik()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(conStr);
            string selectText = "UPDATE İstatistikler SET gKultur_dogru_sayisi=gKultur_dogru_sayisi+@dogru,gKultur_yanlis_sayisi=gKultur_yanlis_sayisi+@yanlis";

            con.Open();
            OleDbCommand cmd = new OleDbCommand(selectText, con);
            cmd.Parameters.Add("@dogru", int.Parse(lblDogruSayi.Text.ToString()));
            cmd.Parameters.Add("@yanlis", int.Parse(lblYanlisSayi.Text.ToString()));
            try
            {
                cmd.ExecuteNonQuery();
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

        public void updateTop()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(conStr);
            string selectText = "UPDATE İstatistikler SET top_dogru_sayisi=(mat_dogru_sayisi+spor_dogru_sayisi+yemek_dogru_sayisi+gKultur_dogru_sayisi),top_yanlis_sayisi=(mat_yanlis_sayisi+spor_yanlis_sayisi+yemek_yanlis_sayisi+gKultur_yanlis_sayisi)";

            con.Open();
            OleDbCommand cmd = new OleDbCommand(selectText, con);
            try
            {
                cmd.ExecuteNonQuery();
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

        public void updateTopPuan()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(conStr);
            string selectText = "UPDATE İstatistikler SET top_puan=(top_dogru_sayisi-top_yanlis_sayisi)";

            con.Open();
            OleDbCommand cmd = new OleDbCommand(selectText, con);
            try
            {
                cmd.ExecuteNonQuery();
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
        private void pbBitir_Click(object sender, EventArgs e)
        {
            frmKategori frm = new frmKategori();
            update_istatistik();
            updateTop();
            updateTopPuan();
            this.Hide();
            frm.Show();
        }

        private void pbIleri_Click_1(object sender, EventArgs e)
        {
            if (sorulacakSoru <= soruSayisi())
            {
                String cevap = cevapBul(sorulacakSoru);
                cevapKontrol(cevap);
                sorulacakSoru += 1;
                Sorusor(sorulacakSoru);
                if (sorulacakSoru == soruSayisi() + 1)
                    MessageBox.Show("Yarışma sona erdi.Puanınız: " + lblPuanGenelKultur.Text.ToString(), "Tebrikler",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
