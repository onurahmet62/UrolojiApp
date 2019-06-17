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

namespace UrolojiApp.Model
{
    public partial class frmAltGrup : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        Formlar frm = new Formlar();
        Mesajlar mesaj = new Mesajlar();
        public bool Secim;
        public frmAltGrup()
        {
            InitializeComponent();
        }

        private void frmAltGrup_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            clbListe.Items.Clear();
            var list = (from s in db.bAltGrups
                        select new
                        {
                            s.Id,
                            s.AltGrup
                        }).Distinct().OrderByDescending(x => x.Id);

            foreach (var item in list)
            {
                clbListe.Items.Add(item.AltGrup);
            }
        }

        void YeniKaydet()
        {
            try
            {
                bAltGrup altGrup = new bAltGrup();
                altGrup.AltGrup = txtAltGrup.Text;
                db.bAltGrups.InsertOnSubmit(altGrup);//Sanal bir tabloya ekliyoruz
                db.SubmitChanges();//Veritabanına kalıcı olarak değişikleri ekliyoruz
                mesaj.YeniKayit("Kayıt Tamamlandı");
                txtAltGrup.Text = "";
                Listele();
            }
            catch (Exception e)
            {

                mesaj.Hata(e);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            frmAnaSayfa.AktarmaS = string.Join("*", clbListe.CheckedItems.OfType<string>().ToList());
            
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < clbListe.CheckedItems.Count; i++)
                {
                    db.bAltGrups.DeleteOnSubmit(db.bAltGrups.First(s => s.AltGrup == clbListe.CheckedItems[i].ToString()));

                }
                db.SubmitChanges();
                //   mesaj.Sil();
                Listele();
            }
            catch (Exception ex)
            {
                mesaj.Hata(ex);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
