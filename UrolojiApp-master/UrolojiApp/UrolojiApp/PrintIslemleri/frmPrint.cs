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
using UrolojiApp.Model;

namespace UrolojiApp.PrintIslemleri
{
    public partial class frmPrint : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        public string HangiListe;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            switch (HangiListe)
            {
                case "UrolojiList":
                    UrolojiList();
                    break;

                case "HastaTakipList":
                    HastaTakipList();
                    break;
                default:
                    break;
            }
        }

        private void UrolojiList()
        {
           frmUrolojiListe lst = Application.OpenForms["urolojilist"] as frmUrolojiListe;

            urolojilist cr = new urolojilist();
            var src = (from s in db.UrolojiFulls
                       select s).ToList();

            if (src!=null)
            {
                PrintYardim ch = new PrintYardim();
                DataTable dt = ch.ConvertTo(src);
                cr.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cr;
            }

        }
        private void HastaTakipList()
        {
            frmUrolojiListe lst = Application.OpenForms["HastaTakipList"] as frmUrolojiListe;

            hastatakiplist cr = new hastatakiplist();
            var src = (from s in db.HastaTakips
                       select s).ToList();

            if (src != null)
            {
                PrintYardim ch = new PrintYardim();
                DataTable dt = ch.ConvertTo(src);
                cr.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cr;
            }

        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
