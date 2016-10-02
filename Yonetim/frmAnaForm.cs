using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yonetim
{
    public partial class frmAnaForm : Form
    {
        Kullanicilar kullanici;
        frmMusteriler frmMusteri;
        frmProjeler frmProje;
        Form frmAktif;
        public frmAnaForm(Kullanicilar kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            musterilerFormunuAc();
            this.Text += " - " + kullanici.AdSoyad;
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle(frmMusteri, null);
            frm.ShowDialog();
        }

        private void btnmusteriler_Click(object sender, EventArgs e)
        {
            musterilerFormunuAc();
        }

        private void btnProjeListesi_Click(object sender, EventArgs e)
        {
            projelerFormunuAc();
        }
        public void musterilerFormunuAc()
        {
            if (frmAktif == null || frmAktif.GetType() != typeof(frmMusteriler))
            {

                if (frmMusteri == null)
                {
                    frmMusteri = new frmMusteriler();
                }
                frmAktif = frmMusteri;
                Helper.loadForm(frmMusteri, pnlana);
            }
        }
        public void projelerFormunuAc()
        {
            if (frmAktif.GetType() != typeof(frmProjeler))
            {
                if (frmProje == null)
                {
                    frmProje = new frmProjeler();
                }
                frmAktif = frmProje;
                Helper.loadForm(frmProje, pnlana);
            }
        }

        private void nvbargrpVersiyonlar_ItemChanged(object sender, EventArgs e)
        {
            projelerFormunuAc();
        }
        private void nvbrGrupfirmalar_ItemChanged(object sender, EventArgs e)
        {
            musterilerFormunuAc();
        }

        private void btnProjeTanimla_Click(object sender, EventArgs e)
        {
            frmProjeEkle frm = new frmProjeEkle(frmProje, null);
            frm.ShowDialog();
        }

    }
}
