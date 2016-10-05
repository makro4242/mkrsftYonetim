using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yonetim
{
    public partial class frmKullaniciEkle : Form
    {
        frmKullanicilar frmKullanici;
        Kullanicilar kullanici;
        public frmKullaniciEkle(frmKullanicilar frmKullanici, Kullanicilar kullanici)
        {
            this.kullanici = kullanici;
            this.frmKullanici = frmKullanici;
            InitializeComponent();
        }

        private void kullaniciEkle_Load(object sender, EventArgs e)
        {
            if (kullanici != null)
            {
                Helper.bindForm(kullanici, groupControl1);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar kullaniciYeni;
            bool yeniKayit = false;
            if (kullanici == null)
            {
                yeniKayit = true;
                kullaniciYeni = new Kullanicilar();
            }
            else
            {
                kullaniciYeni = kullanici;
            }
            Helper.formSave(kullaniciYeni, groupControl1);

            try
            {

                int sonuc = 0;
                if (yeniKayit)
                {
                    sonuc = BusinessLogicLayer.BLLKullanicilar.insert(kullaniciYeni);
                }
                else
                {
                    sonuc = BusinessLogicLayer.BLLKullanicilar.update(kullaniciYeni) ? 1 : 0;
                }
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    if (frmKullanici != null)
                    {
                        frmKullanici.kullanicilariGetir();
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
    }
}
