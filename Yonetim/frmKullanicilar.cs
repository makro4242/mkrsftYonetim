using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;

namespace Yonetim
{
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            kullanicilariGetir();
        }
        public void kullanicilariGetir()
        {
            List<Kullanicilar> kullanicilar = BLLKullanicilar.selectAll();
            if (kullanicilar != null)
            {
                grdCntrlkullanicilar.DataSource = kullanicilar;
            }
        }

        private void btnKsil_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvkullanicilar.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Kullanicilar proje = (Kullanicilar)grdwvkullanicilar.GetRow(rowIndex[0]);
                if (proje != null)
                {
                    DialogResult karar = MessageBox.Show(proje.adsoyad + " İsimli Kullanıcıyı Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (karar == DialogResult.Yes)
                    {
                        BLLKullanicilar.delete(Convert.ToInt32(proje.id));
                        grdwvkullanicilar.DeleteRow(rowIndex[0]);
                    }
                }
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            kullanicilariGetir();
        }

        private void btnkbilgileri_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvkullanicilar.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Kullanicilar m = (Kullanicilar)grdwvkullanicilar.GetRow(rowIndex[0]);
                if (m != null)
                {
                    frmKullaniciEkle frm = new frmKullaniciEkle(this, m);
                    frm.ShowDialog();
                }
            }
        }
    }
}
