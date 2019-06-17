using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Fonksiyonlar;

namespace UrolojiApp
{
    public partial class frmAnaSayfa : Form
    {
        Formlar f = new Formlar();
        public static string AktarmaS;
        public static int AktarmaI;
        
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            gbSol.ForeColor = Color.DarkGreen;
            gbSol.Text = "Bir";
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            gbSol.ForeColor = Color.DarkBlue;
            gbSol.Text = "Bilgi Girişi";
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            gbSol.ForeColor = Color.DarkRed;
            gbSol.Text = "Üç";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnHastaGiris_Click(object sender, EventArgs e)
        {           
            f.HastaGiris();
        }

        private void btnOpTur_Click(object sender, EventArgs e)
        {
            f.OpersayonTuru();
        }

        private void btnHastaBul_Click(object sender, EventArgs e)
        {
            f.HastaBul();
        }

        private void btnUrolojiList_Click(object sender, EventArgs e)
        {
            f.UrolojiListe();
        }
    }
}
