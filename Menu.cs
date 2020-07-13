using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bilg_oyun
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void pbCikis_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pbNasılOynanir_Click(object sender, EventArgs e)
        {
            frmNasilOynanir f = new frmNasilOynanir();
            this.Hide();
            f.Show();
            
           
        
        }

        private void pbOyna_Click(object sender, EventArgs e)
        {
            frmKategori frm = new frmKategori();
            this.Hide();
            frm.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
