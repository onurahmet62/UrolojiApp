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
    public partial class frmHastaBul : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        public bool Secim;
        int secimId = -1;
        public frmHastaBul()
        {
            InitializeComponent();
        }

        private void frmHastaBul_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            gridListe.Rows.Clear();
            int i = 0;
            var bul = (from s in db.bHastaBilgileris
                       where s.HastaAdi.Contains(txtHastaAdi.Text)
                       where s.ProtokolNo.Contains(txtProtNo.Text)
                       select s).ToList();

            foreach (var item in bul)
            {

                gridListe.Rows.Add();
                gridListe.Rows[i].Cells[0].Value = item.Id;
                gridListe.Rows[i].Cells[1].Value = item.ProtokolNo;
                gridListe.Rows[i].Cells[2].Value = item.HastaAdi;
                gridListe.Rows[i].Cells[3].Value = item.HastaSoyadi;
                gridListe.Rows[i].Cells[4].Value = item.OperasyonTarihi;
                i++;
            }
            gridListe.AllowUserToAddRows = false;
            gridListe.AllowUserToDeleteRows = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId>0)
            {
                frmAnaSayfa.AktarmaI = secimId;
                Close();
            }
        }

        /// <summary>
        /// Seçili olan satırın Idsini tutan method
        /// </summary>
        private void Sec()
        {
            try
            {
                secimId = int.Parse(gridListe.CurrentRow.Cells[0].Value.ToString());//Seçili satırın Idsini tutacak
            }
            catch (Exception)
            {
                secimId = -1;
            }

        }
    }
}
