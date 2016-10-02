using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Forms;

namespace Yonetim
{
    public partial class frmMusteriEkle : Form
    {
        frmMusteriler frmMusteri;
        Musteriler musteri;
        public frmMusteriEkle(frmMusteriler frmMusteri, Musteriler musteri)
        {
            this.frmMusteri = frmMusteri;
            this.musteri = musteri;
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Musteriler mstrYeni;
            bool yeniKayit = false;
            if (musteri == null)
            {
                yeniKayit = true;
                mstrYeni = new Musteriler();
            }
            else
            {
                mstrYeni = musteri;
            }
            Helper.formSave(mstrYeni, grpMusteriEkle);

            try
            {

                int sonuc = 0;
                if (yeniKayit)
                {
                    sonuc = BusinessLogicLayer.BLLMusteriler.insert(mstrYeni);
                }
                else
                {
                    sonuc = BusinessLogicLayer.BLLMusteriler.update(mstrYeni) ? 1 : 0;
                }
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    if (frmMusteri != null)
                    {
                        frmMusteri.musterileriGetir();
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılamadı");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            if (musteri != null)
            {
                Helper.bindForm(musteri, grpMusteriEkle);
            }
        }
    }
}
