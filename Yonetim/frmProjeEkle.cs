using EntityLayer;
using System;
using System.Windows.Forms;

namespace Yonetim
{
    public partial class frmProjeEkle : Form
    {
        frmProjeler frmProje;
        Projeler proje;
        public frmProjeEkle(frmProjeler frmProje, Projeler proje)
        {
            this.frmProje = frmProje;
            this.proje = proje;
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Projeler projeYeni;
            bool yeniKayit = false;
            if (proje == null)
            {
                yeniKayit = true;
                projeYeni = new Projeler();
            }
            else
            {
                projeYeni = proje;
            }
            Helper.formSave(projeYeni, groupControl1);

            try
            {

                int sonuc = 0;
                if (yeniKayit)
                {
                    sonuc = BusinessLogicLayer.BLLMusteriler.insert(projeYeni);
                }
                else
                {
                    sonuc = BusinessLogicLayer.BLLMusteriler.update(projeYeni) ? 1 : 0;
                }
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    if (frmProje != null)
                    {
                        frmProje.projeleriGetir();
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
