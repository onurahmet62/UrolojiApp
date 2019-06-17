using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrolojiApp.Fonksiyonlar
{
    /// <summary>
    /// Hata,kayıt ekle, sil, güncelle mesajları için 
    /// </summary>
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Giriş",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir\n" +
                "Güncelleme işlemini onaylıyor musunuz?","Güncelleme İşlemi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrar kaydetmek istiyor musunuz","Kayıt Uyarısı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Tüm kayıtlar kalıcı olarak silinecektir\n" +
                "Silme işlemini onaylıyor musunuz?", "Silme İşlemi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmiştir.","Kayıt Güncelleme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message,"Hata oluştu",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydı yazdırmak itiyor musunuz?",
                "Yazdırma İşlemi",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}
