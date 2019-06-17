using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrolojiApp.Fonksiyonlar
{
    public partial class frmDoktor : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        Mesajlar mesaj = new Mesajlar();
        Formlar f = new Formlar();
        public bool Secim;
        public frmDoktor()
        {
            InitializeComponent();
        }

        private void frmDoktor_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            clbListe.Items.Clear();
            var list = (from s in db.bDoktors
                        select new
                        {
                            s.Id,
                            s.doktorAdiSoyadi
                        }).Distinct().OrderByDescending(x => x.Id);

            foreach (var item in list)
            {
                clbListe.Items.Add(item.doktorAdiSoyadi);
            }
        }

        void YeniKaydet()
        {
            try
            {
                bDoktor dr = new bDoktor();
                dr.doktorAdiSoyadi = txtDoktor.Text;
                db.bDoktors.InsertOnSubmit(dr);//Sanal bir tabloya ekliyoruz
                db.SubmitChanges();//Veritabanına kalıcı olarak değişikleri ekliyoruz
                mesaj.YeniKayit("Kayıt Tamamlandı");
                txtDoktor.Text = "";
                Listele();
            }
            catch (Exception e)
            {

                mesaj.Hata(e);
            }
        }

      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            frmAnaSayfa.AktarmaS = string.Join("*", clbListe.CheckedItems.OfType<string>().ToList());
            //seçilen bütün check verileri tipi string olanları ard arda ekleyerek txt alana atacak   
            //Farklı stringleri araya * koyarak tek bir string halinde birleştirildi

            Close();
        }

        private void brnSil_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < clbListe.CheckedItems.Count; i++)
                {
                    db.bDoktors.DeleteOnSubmit(db.bDoktors.First(s => s.doktorAdiSoyadi == clbListe.CheckedItems[i].ToString()));

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
