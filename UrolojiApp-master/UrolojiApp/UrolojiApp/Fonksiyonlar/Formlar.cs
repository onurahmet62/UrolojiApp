using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Model;

namespace UrolojiApp.Fonksiyonlar
{
    public class Formlar
    {
        public void HastaGiris()
        {
            Model.frmHastaGiris frm = new Model.frmHastaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        /// <summary>
        /// Seçilen opersayon türlerini aktar butonuyla Anasayfadaki operasyon turu txtinde göstermek
        /// </summary>
        /// <param name="secim"></param>
        public void OpersayonTuru(bool secim = false)
        {
            frmOpTuru frm = new frmOpTuru();
            if (secim)
            {
                frm.Secim = true;
                frm.btnAktar.Enabled = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.btnAktar.Enabled = false;
                frm.Show();
            }        
        }//EndOpersayonTuru

        public void DoktorGiris(bool secim = false)
        {
            frmDoktor frm = new frmDoktor();
            if (secim)
            {
                frm.Secim = true;
                frm.btnAktar.Enabled = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.btnAktar.Enabled = false;
                frm.Show();
            }
        }//EndDoktorGiris

        public void AltGrup(bool secim = false)
        {
            frmAltGrup frm = new frmAltGrup();
            if (secim)
            {
                frm.Secim = true;
                frm.btnAktar.Enabled = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.btnAktar.Enabled = false;
                frm.Show();
            }
        }//EndDoktorGiris

        public int HastaBul(bool secim = false)
        {
            frmHastaBul bul = new frmHastaBul();
            if (secim)
            {
                bul.Secim = true;
                bul.ShowDialog();                
            }
            else
            {
                bul.MdiParent = Form.ActiveForm;
                bul.WindowState = FormWindowState.Maximized;
                bul.Show();
            }
            return frmAnaSayfa.AktarmaI;

        }//EndHastaBul

        public void UrolojiListe()
        {
            frmUrolojiListe frm = new frmUrolojiListe();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

    }//EndClassFormlar
}
