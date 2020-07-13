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
    public partial class frmYemek : Form
    {
        private bool suruklenmedurumu = false;
        private Point ilkkonum;
        private Boolean resim1 = false,resim2=false,resim3=false,resim4=false;
        private int puan = 0,seviye = 1;
        public frmYemek()
        {
            InitializeComponent();
        }

        private void pbKontrolSifirla()
        {
            //pbkontrol1
            pbKontrol1.Image = Image.FromFile("bos.png");
            pbKontrol1.SizeMode = PictureBoxSizeMode.StretchImage;

            //pbkontrol2
            pbKontrol2.Image = Image.FromFile("bos.png");
            pbKontrol2.SizeMode = PictureBoxSizeMode.StretchImage;

            //pbkontrol3
            pbKontrol3.Image = Image.FromFile("bos.png");
            pbKontrol3.SizeMode = PictureBoxSizeMode.StretchImage;

            //pbkontrol4
            pbKontrol4.Image = Image.FromFile("bos.png");
            pbKontrol4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void imageLoad1()
        {
            pbOgunResim.Image = Image.FromFile("breakfast/breakfast.jpg");
            pb3.Image = Image.FromFile("breakfast/bread.png");
            pb4.Image = Image.FromFile("breakfast/Cheese.jpg");
            pb5.Image = Image.FromFile("breakfast/eggs.jpg");
            pb6.Image = Image.FromFile("breakfast/milk.png");
        }

        public void imageLoad2()
        {
            pbOgunResim.Image = Image.FromFile("lunch/lunch.jpg");
            pb3.Image = Image.FromFile("lunch/apple.png");
            pb4.Image = Image.FromFile("lunch/hamburger.png");
            pb5.Image = Image.FromFile("lunch/juice.png");
            pb6.Image = Image.FromFile("lunch/sandwich.png");
        }

        public void imageLoad3()
        {
            pbOgunResim.Image = Image.FromFile("dinner/dinner.gif");
            pb3.Image = Image.FromFile("dinner/chicken.jpg");
            pb4.Image = Image.FromFile("dinner/pizza.png");
            pb5.Image = Image.FromFile("dinner/spaghetti.png");
            pb6.Image = Image.FromFile("dinner/fish.png");
        }

        public void imageMode()
        {
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.BringToFront();
            pb4.BringToFront();
            pb5.BringToFront();
            pb6.BringToFront();
        }

        private void frmYemek_Load(object sender, EventArgs e)
        {
            pbKontrolSifirla();
            imageLoad1();
            imageMode();
            
            lblCevap1.Text = "Yumurta";
            lblCevap2.Text = "Ekmek";
            lblCevap3.Text = "Süt";
            lblCevap4.Text = "Peynir";


        }

        private void resimSifirla()
        {
            //pb3
            pb3.Left = 36;
            pb3.Top = 209;
         
            //pb4
            pb4.Left = 151;
            pb4.Top = 205;

            //pb5
            pb5.Left = 251;
            pb5.Top = 207;

            //pb6
            pb6.Left = 370;
            pb6.Top = 211;

            resim1 = resim2 = resim3 = resim4 = false;

        }

        private Boolean resimAyarla(int x1, int x2, int y1, int y2,string pb)
        {
           if(pb == "3")
           {
               if ((pb3.Left > x1 && pb3.Left < x2) && (pb3.Top > y1 && pb3.Top < y2))
                   return true;
           }
           if (pb == "4")
            {
                if ((pb4.Left > x1 && pb4.Left < x2) && (pb4.Top > y1 && pb4.Top < y2))
                    return true;
         
            }
            if (pb == "5")
            {
                if ((pb5.Left > x1 && pb5.Left < x2) && (pb5.Top > y1 && pb5.Top < y2))
                    return true;
                
            }
            if (pb == "6")
            {
                if ((pb6.Left > x1 && pb6.Left < x2) && (pb6.Top > y1 && pb6.Top < y2))
                    return true;
                
            }

            return false;
        }

        private void pb3Kontrol()
        {
            if (pb3.Left == 37 && pb3.Top == 311)
            {
                pbKontrol1.Image = Image.FromFile("yanlis.png");
                pbKontrol1.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb3.Left == 149 && pb3.Top == 311)
            {
                pbKontrol2.Image = Image.FromFile("dogru.png");
                pbKontrol2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb3.Left == 257 && pb3.Top == 311)
            {
                pbKontrol3.Image = Image.FromFile("yanlis.png");
                pbKontrol3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (pb3.Left == 370 && pb3.Top == 311)
            {
                pbKontrol4.Image = Image.FromFile("yanlis.png");
                pbKontrol4.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void pb4Kontrol()
        {
            if (pb4.Left == 37 && pb4.Top == 311)
            {
                pbKontrol1.Image = Image.FromFile("yanlis.png");
                pbKontrol1.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb4.Left == 149 && pb4.Top == 311)
            {
                pbKontrol2.Image = Image.FromFile("yanlis.png");
                pbKontrol2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb4.Left == 257 && pb4.Top == 311)
            {
                pbKontrol3.Image = Image.FromFile("yanlis.png");
                pbKontrol3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (pb4.Left == 370 && pb4.Top == 311)
            {
                pbKontrol4.Image = Image.FromFile("dogru.png");
                pbKontrol4.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            
        }

        private void pb5Kontrol()
        {
            if (pb5.Left == 37 && pb5.Top == 311)
            {
                pbKontrol1.Image = Image.FromFile("dogru.png");
                pbKontrol1.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb5.Left == 149 && pb5.Top == 311)
            {
                pbKontrol2.Image = Image.FromFile("yanlis.png");
                pbKontrol2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb5.Left == 257 && pb5.Top == 311)
            {
                pbKontrol3.Image = Image.FromFile("yanlis.png");
                pbKontrol3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (pb5.Left == 370 && pb5.Top == 311)
            {
                pbKontrol4.Image = Image.FromFile("yanlis.png");
                pbKontrol4.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            
        }

        private void pb6Kontrol()
        {
            if (pb6.Left == 37 && pb6.Top == 311)
            {
                pbKontrol1.Image = Image.FromFile("yanlis.png");
                pbKontrol1.SizeMode = PictureBoxSizeMode.StretchImage;



            }

            if (pb6.Left == 149 && pb6.Top == 311)
            {
                pbKontrol2.Image = Image.FromFile("yanlis.png");
                pbKontrol2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (pb6.Left == 257 && pb6.Top == 311)
            {
                pbKontrol3.Image = Image.FromFile("dogru.png");
                pbKontrol3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (pb6.Left == 370 && pb6.Top == 311)
            {
                pbKontrol4.Image = Image.FromFile("yanlis.png");
                pbKontrol4.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        public void pbSonucKontrol()
        {
            pb3Kontrol();
            pb4Kontrol();
            pb5Kontrol();
            pb6Kontrol();
            
        }

        private void frmYemek_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmKategori frm = new frmKategori();
            frm.Show();
        }
        
        private void pb3_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = true; 
            pb3.Cursor = Cursors.Arrow; 
            ilkkonum = e.Location;
            
        }

        private void pb3_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenmedurumu) 
            {
                pb3.Left = e.X + pb3.Left - (ilkkonum.X);
                pb3.Top = e.Y + pb3.Top - (ilkkonum.Y);
           
            }
      
        }
        
        private void pb3_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
            if (resimAyarla(0,70,276,356,"3"))
            {
                resim1 = true;
                pb3.Left = 37;
                pb3.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(115, 190, 281, 346,"3"))
            {
                resim1 = true;
                pb3.Left = 149;
                pb3.Top = 311;
                pbSonucKontrol();
            }
            else if (resimAyarla(222, 291, 285, 347,"3"))
            {
                resim1 = true;
                pb3.Left = 257;
                pb3.Top = 311;
                pbSonucKontrol();
            }
            else if (resimAyarla(338, 408, 283, 346, "3"))
            {
                resim1 = true;
                pb3.Left = 370;
                pb3.Top = 311;
                pbSonucKontrol();
            }
            else
            {
                resim1 = false;
                pb3.Left = 36;
                pb3.Top = 209;
                pbSonucKontrol();
                
            }
            pb3.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
        }

        private void pb4_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = true;
            pb4.Cursor = Cursors.Arrow;
            ilkkonum = e.Location; 

        }

        private void pb4_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenmedurumu)
            {
                pb4.Left = e.X + pb4.Left - (ilkkonum.X);
                pb4.Top = e.Y + pb4.Top - (ilkkonum.Y);

            }

        }

        private void pb4_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
         
            if (resimAyarla(7, 74, 287, 347, "4"))
            {
                resim2 = true;
                pb4.Left = 37;
                pb4.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(124, 183, 293, 339, "4"))
            {
                resim2 = true;
                pb4.Left = 149;
                pb4.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(232, 284, 285, 339, "4"))
            {
                resim2 = true;
                pb4.Left = 257;
                pb4.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(344, 400, 293, 341, "4"))
            {
                resim2 = true;
                pb4.Left = 370;
                pb4.Top = 311;
                pbSonucKontrol();

            }
            else
            {
                resim2 = false;
                pb4.Left = 151;
                pb4.Top = 205;
                pbSonucKontrol();
                
            }
            
            
            pb4.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.

        }

        private void pb5_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = true;
            pb5.Cursor = Cursors.Arrow;
            ilkkonum = e.Location; 
        }

        private void pb5_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenmedurumu)
            {
                pb5.Left = e.X + pb5.Left - (ilkkonum.X);
                pb5.Top = e.Y + pb5.Top - (ilkkonum.Y);
                
            }
        }

        private void pb5_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
            if (resimAyarla(0, 71, 288, 344, "5"))
            {
                resim3 = true;
                pb5.Left = 37;
                pb5.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(116, 181, 288, 348, "5"))
            {
                resim3 = true;
                pb5.Left = 149;
                pb5.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(226, 287, 288, 348, "5"))
            {
                resim3 = true;
                pb5.Left = 257;
                pb5.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(335, 411, 288, 348, "5"))
            {
                resim3 = true;
                pb5.Left = 370;
                pb5.Top = 311;
                pbSonucKontrol();

            }
            else
            {
                resim3 = false;
                pb5.Left = 251;
                pb5.Top = 207;
                pbSonucKontrol();
           }
            
            
            pb5.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
        }

        private void pb6_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = true;
            pb6.Cursor = Cursors.Arrow;
            ilkkonum = e.Location; 
        }

        private void pb6_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenmedurumu)
            {
                pb6.Left = e.X + pb6.Left - (ilkkonum.X);
                pb6.Top = e.Y + pb6.Top - (ilkkonum.Y);

               
            }
        }

        private void pb6_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
            if (resimAyarla(7, 78, 288, 344, "6"))
            {
                resim4 = true;
                pb6.Left = 38;
                pb6.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(118, 187, 288, 348, "6"))
            {
                resim4 = true;
                pb6.Left = 149;
                pb6.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(232, 289, 288, 348, "6"))
            {
                resim4 = true;
                pb6.Left = 257;
                pb6.Top = 311;
                pbSonucKontrol();

            }
            else if (resimAyarla(340, 406, 288, 348, "6"))
            {
                resim4 = true;
                pb6.Left = 370;
                pb6.Top = 311;
                pbSonucKontrol();

            }
            else
            {
                resim4 = false;
                pb6.Left = 370;
                pb6.Top = 211;
                pbSonucKontrol();
            }
            
            pb6.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
        }

        public void update_istatistik()
        {
            String conStr = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=bilgi_yarismasi.accdb";
            OleDbConnection con = new OleDbConnection(conStr);
            string selectText = "UPDATE İstatistikler SET yemek_dogru_sayisi=yemek_dogru_sayisi+@dogru,yemek_yanlis_sayisi=yemek_yanlis_sayisi+@yanlis";

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

       
        
        private void pbKontrolEt_Click(object sender, EventArgs e)
        {
            if (resim1 && resim2 && resim3 && resim4)
            {
                if ((pb5.Left == 37 && pb5.Top == 311) && (pb3.Left == 149 && pb3.Top == 311)
                    && (pb6.Left == 257 && pb6.Top == 311) && (pb4.Left == 370 && pb4.Top == 311))
                {
                   
                   seviye++;
                    
                    if (seviye >= 4)
                    {
                        
                        if (MessageBox.Show("Tebrikler oyunu tamamladınız.Başka kategorilerde yarışmak ister misiniz?",
                            "Bilgi yarışması", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                            DialogResult.Yes)
                        {
                            frmKategori frm = new frmKategori();
                            update_istatistik();
                            updateTop();
                            updateTopPuan();
                            this.Hide();
                            frm.Show();

                        }
                        else
                        {
                            update_istatistik();
                            updateTop();
                            updateTopPuan();
                            
                        }
                    }
                    else
                    {
                     MessageBox.Show("Tebrikler diğer seviyeye geçtiniz.", "Bilgi yarışması", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        lblDogruSayi.Text = (int.Parse(lblDogruSayi.Text) + 1).ToString();
                        lblPuanYemek.Text = (int.Parse(lblDogruSayi.Text) - int.Parse(lblYanlisSayi.Text)).ToString();
                        digerSeviye();
                        
                      
                    }
                        
                }
                else
                {
                    MessageBox.Show("Üzgünüm cevaplarınızı kontrol edin lütfen", "Bilgi yarışması", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    lblYanlisSayi.Text = (int.Parse(lblYanlisSayi.Text) + 1).ToString();
                    lblPuanYemek.Text = (int.Parse(lblDogruSayi.Text) - int.Parse(lblYanlisSayi.Text)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen resimleri yerlerine yerleştirin", "Bilgi Yarışması", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void digerSeviye()
        {
            if (seviye == 2)
            {
                lblSoru.Text = "Aşağıda öğle yemeği için yediğimiz yiyecekleri uygun yere yerleştiriniz";
                lblCevap1.Text = "Meyve Suyu";
                lblCevap2.Text = "Elma";
                lblCevap3.Text = "Sandviç";
                lblCevap4.Text = "Hamburger";

                pbKontrolSifirla();
                resimSifirla();
                imageLoad2();
                imageMode();
            }
            if (seviye == 3)
            {
                lblSoru.Text = "Aşağıda akşam yemeği için yediğimiz yiyecekleri uygun yere yerleştiriniz";
                lblCevap1.Text = "Spagetti";
                lblCevap2.Text = "Tavuk";
                lblCevap3.Text = "Balık";
                lblCevap4.Text = "Pizza";


                pbKontrolSifirla();
                resimSifirla();
                imageLoad3();
                imageMode();
                
            }

            


        }

       
    }
}
