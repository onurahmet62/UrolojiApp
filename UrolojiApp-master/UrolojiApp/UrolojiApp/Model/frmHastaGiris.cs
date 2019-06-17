using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Fonksiyonlar;

namespace UrolojiApp.Model
{
    public partial class frmHastaGiris : Form
    {
        UrolojiDBDataContext db = new UrolojiDBDataContext();
        Mesajlar mesaj = new Mesajlar();
        private bool _edit;
        Formlar f = new Formlar();
        int _hastaId = -1;
        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GÖSTER";
            }
        }

        void BmiHesap()
        {
            if (txtBoy.Text != "" && txtKilo.Text != "" && txtBoy.Text != "0" && txtKilo.Text != "0")
            {
                decimal boy, kilo, bmi;
                boy = decimal.Parse(txtBoy.Text);
                kilo = decimal.Parse(txtKilo.Text);
                //  bmi = (kilo/((boy*boy)/10000));
                bmi = Math.Round((kilo / ((boy * boy) / 10000)), 2);
                txtBMI.Text = bmi.ToString();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _hastaId > 0 && mesaj.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (_edit==false)
            {
                YeniKaydet(); 
            }           
        }

        void Guncelle()
        {

            try
            {
                bHastaBilgileri hasta = db.bHastaBilgileris.First(x => x.Id == _hastaId);
                {
                    hasta.HastaAdi = txtHastaAdi.Text;
                    hasta.HastaSoyadi = txtHastaSoyadi.Text;
                    hasta.ProtokolNo = txtProtokolNo.Text;
                    hasta.OperasyonTarihi = DateTime.Parse(dtpOpTarihi.Text);
                    hasta.OperasyonTuru = txtOpTuru.Text;
                    hasta.Takip = int.Parse(txtTakip.Text);
                    hasta.Anah = int.Parse(txtAnah.Text);
                }

                bDemografik demo = db.bDemografiks.First(x => x.HastaId == _hastaId);
                {
                    demo.Asa = cmbAsa.Text != "" ? int.Parse(cmbAsa.Text) : -1;
                    demo.Bmi = txtBMI.Text != "" ? decimal.Parse(txtBMI.Text) : -1;
                    demo.Boy = txtBoy.Text != "" ? int.Parse(txtBoy.Text) : -1;
                    demo.Boyut = txtBoyut.Text;
                    demo.Cins = cmbCinsiyet.Text;
                    demo.Dr = txtDoktor.Text;
                    demo.Kilo = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                    demo.Ko_Morbit = txtKoMorbite.Text;
                    demo.Lokalizasyon = txtLokal.Text;
                    demo.Taraf = cmbTaraf.Text;
                    demo.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;
                }

                bOperatif operatif = db.bOperatifs.First(x => x.HastaId == _hastaId);
                {
                    operatif.PksAciklama = cmbPksAciklama.Text;
                    operatif.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
                    operatif.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                    operatif.Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1;
                    operatif.PortSayisi = txtPortSayisi.Text != "" ? int.Parse(txtPortSayisi.Text) : -1;
                    operatif.Sikayet = txtSikayet.Text;
                    operatif.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                    operatif.YardimYnt = txtYardimYnt.Text;

                }

                bPostOperatif pos = db.bPostOperatifs.First(x => x.HastaId == _hastaId);
                {
                    pos.HospSuresi = txtHospSuresi.Text != "" ? int.Parse(txtHospSuresi.Text) : -1;
                    pos.KompKlavien = cmbKompClavien.Text;
                    pos.Pek = cmbPerEKomp.Text;
                    pos.PostOpAnaliz = txtPostOpAnaliz.Text;
                    pos.PostOpGKomp = txtPostOpGecKamp.Text;
                    pos.PostOpHb = txtPostOpHb.Text != "" ? decimal.Parse(txtPostOpHb.Text) : -1;
                    pos.PostOpKreatin = txtPostOpKreatin.Text != "" ? decimal.Parse(txtPostOpKreatin.Text) : -1;
                    pos.PreOpKreatin = txtPreOpKreatin.Text != "" ? decimal.Parse(txtPreOpKreatin.Text) : -1;
                    pos.PostOpHct = txtPostOpHct.Text != "" ? decimal.Parse(txtPostOpHct.Text) : -1;
                    pos.PreOpHct = txtPreOpHct.Text != "" ? decimal.Parse(txtPreOpHct.Text) : -1;
                    pos.Sonda = cmbSonda.Text;
                    pos.TakipAy = txtTakip.Text;
                    pos.Tel = txtTel.Text;
                }

                bPatoloji pat = db.bPatolojis.First(x => x.HastaId == _hastaId);
                {
                    pat.AltGrup = txtAltGrup.Text;
                    pat.CerrahSinir = cmbCerrahiSinir.Text;
                    pat.FuhrmanGrade = cmbFuhrmanGrade.Text;
                    pat.Pataloji = txtPatoloji.Text;
                    pat.PatalojikEvre = cmbPatolojikEvre.Text;
                }

                bTakip tk = db.bTakips.First(x => x.HastaId == _hastaId);
                {
                    tk.P12AyKreatin = txtP12AyKreatin.Text != "" ? decimal.Parse(txtP12AyKreatin.Text) : -1;
                    tk.P12AyLokal = cmbP12AyLokal.Text;
                    tk.P6AyKreatin = txtP6AyKreatin.Text != "" ? decimal.Parse(txtP6AyKreatin.Text) : -1;
                    tk.P6AyLocal = cmbP6AyLokal.Text;
                    tk.P3AyKreatin = txtP3AyKreatin.Text != "" ? decimal.Parse(txtP3AyKreatin.Text) : -1;
                    tk.P3AyLokal = cmbP3AyLokal.Text;
                }

                db.SubmitChanges();
                mesaj.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                mesaj.Hata(e);
            }
        }
        void YeniKaydet()
        {
            bHastaBilgileri hasta = new bHastaBilgileri();
            {
                hasta.HastaAdi = txtHastaAdi.Text;
                hasta.HastaSoyadi = txtHastaSoyadi.Text;
                hasta.ProtokolNo = txtProtokolNo.Text;
                hasta.OperasyonTarihi = DateTime.Parse(dtpOpTarihi.Text);
                hasta.OperasyonTuru = txtOpTuru.Text;
                hasta.Takip = int.Parse(txtTakip.Text);
                hasta.Anah = int.Parse(txtAnah.Text);
            }
            db.bHastaBilgileris.InsertOnSubmit(hasta);
            db.SubmitChanges();

            bDemografik demo = new bDemografik();
            {
                demo.Asa = cmbAsa.Text != "" ? int.Parse(cmbAsa.Text) : -1;
                demo.Bmi = txtBMI.Text != "" ? decimal.Parse(txtBMI.Text) : -1;
                demo.Boy = txtBoy.Text != "" ? int.Parse(txtBoy.Text) : 0;
                demo.Boyut = txtBoyut.Text;
                demo.Cins = cmbCinsiyet.Text;
                demo.Dr = txtDoktor.Text;
                demo.HastaId = hasta.Id != 0 ? hasta.Id : -1;
                demo.Kilo = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : 0;
                demo.Ko_Morbit = txtKoMorbite.Text;
                demo.Lokalizasyon = txtLokal.Text;
                demo.Taraf = cmbTaraf.Text;
                demo.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;

                db.bDemografiks.InsertOnSubmit(demo);
            }

            db.SubmitChanges();

            bOperatif operatif = new bOperatif();
            {
                operatif.HastaId = hasta.Id != 0 ? hasta.Id : -1;
                operatif.PksAciklama = cmbPksAciklama.Text;
                operatif.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
                operatif.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                operatif.Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1;
                operatif.PortSayisi = txtPortSayisi.Text != "" ? int.Parse(txtPortSayisi.Text) : -1;
                operatif.Sikayet = txtSikayet.Text;
                operatif.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                operatif.YardimYnt = txtYardimYnt.Text;

                db.bOperatifs.InsertOnSubmit(operatif);
            }
            db.SubmitChanges();

            bPostOperatif pos = new bPostOperatif();
            {
                pos.HastaId = hasta.Id != 0 ? hasta.Id : -1;
                pos.HospSuresi = txtHospSuresi.Text != "" ? int.Parse(txtHospSuresi.Text) : -1;
                pos.KompKlavien = cmbKompClavien.Text;
                pos.Pek = cmbPerEKomp.Text;
                pos.PostOpAnaliz = txtPostOpAnaliz.Text;
                pos.PostOpGKomp = txtPostOpGecKamp.Text;
                pos.PostOpHb = txtPostOpHb.Text != "" ? decimal.Parse(txtPostOpHb.Text) : -1;
                pos.PostOpKreatin = txtPostOpKreatin.Text != "" ? decimal.Parse(txtPostOpKreatin.Text) : -1;
                pos.PreOpKreatin = txtPreOpKreatin.Text != "" ? decimal.Parse(txtPreOpKreatin.Text) : -1;
                pos.PostOpHct = txtPostOpHct.Text != "" ? decimal.Parse(txtPostOpHct.Text) : -1;
                pos.PreOpHct = txtPreOpHct.Text != "" ? decimal.Parse(txtPreOpHct.Text) : -1;
                pos.Sonda = cmbSonda.Text;
                pos.TakipAy = txtTakip.Text;
                pos.Tel = txtTel.Text;

                db.bPostOperatifs.InsertOnSubmit(pos);
            }
            db.SubmitChanges();


            bPatoloji pat = new bPatoloji();
            {
                pat.HastaId = hasta.Id != 0 ? hasta.Id : -1;
                pat.AltGrup = txtAltGrup.Text;
                pat.CerrahSinir = cmbCerrahiSinir.Text;
                pat.FuhrmanGrade = cmbFuhrmanGrade.Text;
                pat.Pataloji = txtPatoloji.Text;
                pat.PatalojikEvre = cmbPatolojikEvre.Text;

                db.bPatolojis.InsertOnSubmit(pat);
            }
            db.SubmitChanges();


            bTakip tk = new bTakip();
            {
                tk.HastaId = hasta.Id;
                tk.P12AyKreatin = txtP12AyKreatin.Text != "" ? decimal.Parse(txtP12AyKreatin.Text) : -1;
                tk.P12AyLokal = cmbP12AyLokal.Text;
                tk.P6AyKreatin = txtP6AyKreatin.Text != "" ? decimal.Parse(txtP6AyKreatin.Text) : -1;
                tk.P6AyLocal = cmbP6AyLokal.Text;
                tk.P3AyKreatin = txtP3AyKreatin.Text != "" ? decimal.Parse(txtP3AyKreatin.Text) : -1;
                tk.P3AyLokal = cmbP3AyLokal.Text;

                db.bTakips.InsertOnSubmit(tk);
            }

            db.SubmitChanges();
            mesaj.YeniKayit("Kayıt işlemi yapıldı.");
            Temizle();
        }
        void Temizle()
        {
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }

            _edit = false;
            _hastaId = -1;
            frmAnaSayfa.AktarmaI = -1;
            frmAnaSayfa.AktarmaS = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            var btnoptur = new Button();
            btnoptur.Size = new Size(25, txtOpTuru.ClientSize.Height + 2);
            btnoptur.Location = new Point(txtOpTuru.ClientSize.Width - btnoptur.Width, -1);
            btnoptur.Cursor = Cursors.Default;
            txtOpTuru.Controls.Add(btnoptur);
            SendMessage(txtOpTuru.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnoptur.Width << 16));
            btnoptur.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            var btnDoktor = new Button();
            btnDoktor.Size = new Size(25, txtDoktor.ClientSize.Height + 2);
            btnDoktor.Location = new Point(txtDoktor.ClientSize.Width - btnDoktor.Width, -1);
            btnDoktor.Cursor = Cursors.Default;
            txtDoktor.Controls.Add(btnDoktor);
            SendMessage(txtDoktor.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnDoktor.Width << 16));
            btnDoktor.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            var btnAltGrup = new Button();
            btnAltGrup.Size = new Size(25, txtAltGrup.ClientSize.Height + 2);
            btnAltGrup.Location = new Point(txtAltGrup.ClientSize.Width - btnAltGrup.Width, -1);
            btnAltGrup.Cursor = Cursors.Default;
            txtAltGrup.Controls.Add(btnAltGrup);
            SendMessage(txtAltGrup.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnAltGrup.Width << 16));
            btnAltGrup.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnBul = new Button();
            btnBul.Size = new Size(25, txtHastaId.ClientSize.Height + 2);
            btnBul.Location = new Point(txtHastaId.ClientSize.Width - btnBul.Width, -1);
            btnBul.Cursor = Cursors.Default;
            txtHastaId.Controls.Add(btnBul);
            SendMessage(txtHastaId.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnBul.Width << 16));
            btnBul.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnBul.Click += btnBul_Click;
            btnAltGrup.Click += btnAltGrup_Click;
            btnDoktor.Click += btnDoktor_Click;
            btnoptur.Click += btnoptur_Click;//Botona Click eventi vermek
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int id = f.HastaBul(true);
            if (id > 0)
            {
                HastaAc(id);
            }
            frmAnaSayfa.AktarmaI = -1;

        }

        private void HastaAc(int id)
        {
            _edit = true;
            _hastaId = id;
            bHastaBilgileri hasta = db.bHastaBilgileris.First(x => x.Id == id);
            {
                txtHastaId.Text = hasta.Id.ToString();
                txtHastaAdi.Text = hasta.HastaAdi;
                txtHastaSoyadi.Text = hasta.HastaSoyadi;
                txtProtokolNo.Text = hasta.ProtokolNo;
                dtpOpTarihi.Text = (hasta.OperasyonTarihi).ToString();
                txtOpTuru.Text = hasta.OperasyonTuru;
                txtTakip.Text = (hasta.Takip).ToString();
                txtAnah.Text = (hasta.Anah).ToString();

            }

            bDemografik demo = db.bDemografiks.First(x => x.HastaId == id);
            {
                cmbAsa.Text = demo.Asa.ToString();
                txtBMI.Text = demo.Bmi.ToString();
                txtBoy.Text = demo.Boy.ToString();
                txtBoyut.Text = demo.Boyut;
                cmbCinsiyet.Text = demo.Cins;
                txtDoktor.Text = demo.Dr;
                txtKilo.Text = demo.Kilo.ToString();
                txtKoMorbite.Text = demo.Ko_Morbit;
                txtLokal.Text = demo.Lokalizasyon;
                cmbTaraf.Text = demo.Taraf;
                txtYas.Text = demo.Yas.ToString();
            }

            bOperatif operatif = db.bOperatifs.First(x => x.HastaId == id);
            {

                cmbPksAciklama.Text = operatif.PksAciklama;
                txtIskemi.Text = operatif.Iskemi.ToString();
                txtKanama.Text = operatif.Kanama.ToString();
                txtPiyes.Text = operatif.Piyes.ToString();
                txtPortSayisi.Text = operatif.PortSayisi.ToString();
                txtSikayet.Text = operatif.Sikayet;
                txtSure.Text = operatif.Sure.ToString();
                txtYardimYnt.Text = operatif.YardimYnt;

            }

            bPostOperatif pos = db.bPostOperatifs.First(x => x.HastaId == id);
            {
                txtHospSuresi.Text = pos.HospSuresi.ToString();
                cmbKompClavien.Text = pos.KompKlavien;
                cmbPerEKomp.Text = pos.Pek;
                txtPostOpAnaliz.Text = pos.PostOpAnaliz;
                txtPostOpGecKamp.Text = pos.PostOpGKomp;
                txtPostOpHb.Text = pos.PostOpHb.ToString();
                txtPostOpKreatin.Text = pos.PostOpKreatin.ToString();
                txtPreOpKreatin.Text = pos.PreOpKreatin.ToString();
                txtPostOpHct.Text = pos.PostOpHct.ToString();
                txtPreOpHct.Text = pos.PreOpHct.ToString();
                cmbSonda.Text = pos.Sonda;
                txtTakip.Text = pos.TakipAy;
                txtTel.Text = pos.Tel;
            }

            bPatoloji pat = db.bPatolojis.First(x => x.HastaId == id);
            {
                txtAltGrup.Text = pat.AltGrup;
                cmbCerrahiSinir.Text = pat.CerrahSinir;
                cmbFuhrmanGrade.Text = pat.FuhrmanGrade;
                txtPatoloji.Text = pat.Pataloji;
                cmbPatolojikEvre.Text = pat.PatalojikEvre;
            }

            bTakip tk = db.bTakips.First(x => x.HastaId == id);
            {
                txtP12AyKreatin.Text = tk.P12AyKreatin.ToString();
                cmbP12AyLokal.Text = tk.P12AyLokal.ToString();
                txtP6AyKreatin.Text = tk.P6AyKreatin.ToString();
                cmbP6AyLokal.Text = tk.P6AyLocal;
                txtP3AyKreatin.Text = tk.P3AyKreatin.ToString();
                cmbP3AyLokal.Text = tk.P3AyLokal;
            }
        }

        private void btnAltGrup_Click(object sender, EventArgs e)
        {
            f.AltGrup(true);
            if (frmAnaSayfa.AktarmaS != "")
            {
                AltGrupAc();
            }
            else MessageBox.Show("Aktarma veri boş kontrol edin!");
        }
        void AltGrupAc()
        {
            txtAltGrup.Text = frmAnaSayfa.AktarmaS;
        }
        private void btnDoktor_Click(object sender, EventArgs e)
        {
            f.DoktorGiris(true);
            if (frmAnaSayfa.AktarmaS != "")
            {
                DrAc();
            }
            else MessageBox.Show("Aktarma veri boş kontrol edin!");
        }
        void DrAc()
        {
            txtDoktor.Text = frmAnaSayfa.AktarmaS;
        }
        private void btnoptur_Click(object sender, EventArgs e)
        {
            f.OpersayonTuru(true);
            if (frmAnaSayfa.AktarmaS != "")
            {
                OpAc();
            }
            else MessageBox.Show("Aktarma veri boş kontrol edin!");

        }

        void OpAc()
        {
            txtOpTuru.Text = frmAnaSayfa.AktarmaS;
        }


        [DllImport("user32.dll")]

        private static extern IntPtr SendMessage(IntPtr hWn, int msg, IntPtr wp, IntPtr lp);

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoy_TextChanged(object sender, EventArgs e)
        {
            BmiHesap();
        }

        private void txtKilo_TextChanged(object sender, EventArgs e)
        {
            BmiHesap();
        }

        private void txtAnah_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
