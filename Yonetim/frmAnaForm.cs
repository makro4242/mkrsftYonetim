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
        frmKullanicilar frmKullanici;
        frmLisanslar frmLisans;
        Form frmAktif;
        public frmAnaForm(Kullanicilar kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            musterilerFormunuAc();
            this.Text += " - " + kullanici.adsoyad;
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
        public void kullanicilarFormunuAc()
        {
            if (frmAktif.GetType() != typeof(frmKullanicilar))
            {
                if (frmKullanici == null)
                {
                    frmKullanici = new frmKullanicilar();
                }
                frmAktif = frmKullanici;
                Helper.loadForm(frmKullanici, pnlana);
            }
        }
        public void lisanslarFormunuAc()
        {
            if (frmAktif.GetType() != typeof(frmLisanslar))
            {
                if (frmLisans == null)
                {
                    frmLisans = new frmLisanslar();
                }
                frmAktif = frmLisans;
                Helper.loadForm(frmLisans, pnlana);
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

        private void btnklistesi_Click(object sender, EventArgs e)
        {
            kullanicilarFormunuAc();
        }

        private void btnkullaniciekle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frm = new frmKullaniciEkle(frmKullanici, null);
            frm.ShowDialog();
        }

        private void nvbrgrpKullanici_ItemChanged(object sender, EventArgs e)
        {
            kullanicilarFormunuAc();
        }

        private void nvbrgrpLisans_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            lisanslarFormunuAc();

        }

        private void btnLisanslar_Click(object sender, EventArgs e)
        {
            lisanslarFormunuAc();

        }

        private void btnLisansEkle_Click(object sender, EventArgs e)
        {
            frmLisansEkle frm = new frmLisansEkle();
            frm.ShowDialog();
        }

    }
}
