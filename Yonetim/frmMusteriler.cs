using System;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;
using System.Collections.Generic;

namespace Yonetim
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            musterileriGetir();
        }
        public void musterileriGetir()
        {

            List<Musteriler> lstMusteriler = BusinessLogicLayer.BLLMusteriler.selectAll();
            grdCntrlmusteriler.DataSource = lstMusteriler;

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            musterileriGetir();
        }

        private void btnmsil_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvmusteriler.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Musteriler m = (Musteriler)grdwvmusteriler.GetRow(rowIndex[0]);
                if (m != null)
                {
                    DialogResult karar = MessageBox.Show(m.firmaadi + " Firmasını Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (karar == DialogResult.Yes)
                    {
                        BLLMusteriler.delete(Convert.ToInt32(m.id));
                        grdwvmusteriler.DeleteRow(rowIndex[0]);
                    }
                }
            }
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle(this, null);
            frm.ShowDialog();
        }

        private void btnmusteribilgi_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvmusteriler.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Musteriler m = (Musteriler)grdwvmusteriler.GetRow(rowIndex[0]);
                if (m != null)
                {
                    frmMusteriEkle frm = new frmMusteriEkle(this, m);
                    frm.ShowDialog();
                }
            }
        }




    }
}
