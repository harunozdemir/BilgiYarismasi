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
    public partial class frmNasilOynanir : Form
    {
        public frmNasilOynanir()
        {
            InitializeComponent();
        }

   

        private void pbAnaMenu_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
           
      
        }

        private void frmNasilOynanir_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            //this.Hide();
        }

    }
}
