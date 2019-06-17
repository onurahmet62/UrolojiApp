using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrolojiApp.Model
{
    public partial class frmUrolojiListe : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        public frmUrolojiListe()
        {
            InitializeComponent();
        }

        private void frmUrolojiListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            var list = (from s in db.UrolojiFulls
                        select s
                      ).ToList();

            gridListe.DataSource = list.ToList();
        }

        private void HastaTakipListe()
        {
            var list= (from s in db.HastaTakips
                       select s
                      ).ToList();

            gridListe.DataSource = list.ToList();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintIslemleri.frmPrint frm = new PrintIslemleri.frmPrint();

            frm.HangiListe = "UrolojiList";
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnHastaTakip_Click(object sender, EventArgs e)
        {
            PrintIslemleri.frmPrint frm = new PrintIslemleri.frmPrint();

            frm.HangiListe = "HastaTakipList";
            frm.MdiParent = Application.OpenForms["frmAnaSayfa"] as frmAnaSayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
