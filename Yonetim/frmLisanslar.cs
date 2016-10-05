using BusinessLogicLayer;
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
    public partial class frmLisanslar : Form
    {
        public frmLisanslar()
        {
            InitializeComponent();
        }
        public void lisanslariGetir()
        {
            List<Lisanslar> kullanicilar = BLLLisanslar.selectAll();
            if (kullanicilar != null)
            {
                grdCntrlLisanslar.DataSource = kullanicilar;
            }
        }
        private void frmLisanslar_Load(object sender, EventArgs e)
        {
            lisanslariGetir();
        }

        private void btnLisansbilgi_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvLisanslar.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Lisanslar m = (Lisanslar)grdwvLisanslar.GetRow(rowIndex[0]);
                if (m != null)
                {
                    frmLisansBilgileri frm = new frmLisansBilgileri(m);
                    frm.ShowDialog();
                }
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            lisanslariGetir();
        }

        private void btnLsil_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvLisanslar.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Lisanslar proje = (Lisanslar)grdwvLisanslar.GetRow(rowIndex[0]);
                if (proje != null)
                {
                    DialogResult karar = MessageBox.Show(proje.lisansanahtari + " Lisans Anahtarını Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (karar == DialogResult.Yes)
                    {
                        BLLLisanslar.delete(Convert.ToInt32(proje.id));
                        grdwvLisanslar.DeleteRow(rowIndex[0]);
                    }
                }
            }
        }

        private void btnLisansEkle_Click(object sender, EventArgs e)
        {
            frmLisansEkle frm = new frmLisansEkle();
            frm.ShowDialog();
        }
    }
}
