using System;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;
using System.Collections.Generic;

namespace Yonetim
{
    public partial class frmProjeler : Form
    {
        public frmProjeler()
        {
            InitializeComponent();
        }

        private void frmProjeler_Load(object sender, EventArgs e)
        {
            projeleriGetir();
        }
        public void projeleriGetir()
        {
            List<Projeler> lstMusteriler = BusinessLogicLayer.BLLProjeler.selectAll();
            grdCntrlProjeler.DataSource = lstMusteriler;
        }

        private void btnProjeekle_Click(object sender, EventArgs e)
        {
            frmProjeEkle frm = new frmProjeEkle(this, null);
            frm.ShowDialog();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            projeleriGetir();
        }

        private void btnProjesil_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvProjeler.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Projeler proje = (Projeler)grdwvProjeler.GetRow(rowIndex[0]);
                if (proje != null)
                {
                    DialogResult karar = MessageBox.Show(proje.padi + " Projesini Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (karar == DialogResult.Yes)
                    {
                        BLLProjeler.delete(Convert.ToInt32(proje.id));
                        grdwvProjeler.DeleteRow(rowIndex[0]);
                    }
                }
            }
        }
    }
}
