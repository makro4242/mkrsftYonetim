using System;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;
using System.Collections.Generic;

namespace Yonetim
{
    public partial class frmLisansEkle : Form
    {
        public frmLisansEkle()
        {
            InitializeComponent();
        }
        List<int> lstFirmaID = new List<int>();
        List<int> lstProjeID = new List<int>();
        string firmaKodu = "";
        public void firmaGetir()
        {
            List<Musteriler> lst = BLLMusteriler.selectAll("id,firmaadi", null);
            if (lst != null)
            {
                foreach (Musteriler item in lst)
                {
                    cmbxFirmaadi.Properties.Items.Add(item.firmaadi);
                    lstFirmaID.Add(item.id);
                }
            }
        }
        public void projeGetir()
        {
            List<Projeler> lst = BLLProjeler.selectAll("id,padi", null);
            if (lst != null)
            {
                foreach (Projeler item in lst)
                {
                    cmbxprojeadi.Properties.Items.Add(item.padi);
                    lstProjeID.Add(item.id);
                }
            }
        }
        private void frmLisansEkle_Load(object sender, EventArgs e)
        {
            firmaGetir();
            projeGetir();
        }
        private void cmbxFirmaadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbxFirmaadi.SelectedIndex;
            if (index >= 0)
            {
                int firmaID = lstFirmaID[index];
                Musteriler m = BLLMusteriler.select(firmaID);
                firmaKodu = m.firmakodu;
                Helper.bindForm(m, grpFirma);
            }
            lisanslariGetir();
        }
        private void cmbxprojeadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbxprojeadi.SelectedIndex;
            if (index >= 0)
            {
                int firmaID = lstProjeID[index];
                Projeler m = BLLProjeler.select(firmaID);
                Helper.bindForm(m, grpProje);
            }
            lisanslariGetir();
        }
        public void lisanslariGetir()
        {
            if (cmbxFirmaadi.SelectedIndex > -1 && cmbxprojeadi.SelectedIndex > -1)
            {
                Dictionary<string, string> dtWhere = new Dictionary<string, string>();
                dtWhere.Add("firmaid", lstFirmaID[cmbxFirmaadi.SelectedIndex].ToString());
                dtWhere.Add("projekodu", txtpkodu.Text);
                List<Lisanslar> lstLisanslar = BLLLisanslar.selectAll("id,padi,lisansanahtari,lisansdurumu", dtWhere);
                grdCntrlanahtarlar.DataSource = lstLisanslar;
            }
        }
        public void lisansUret()
        {
            string anahtar = "";
            Random rndm = new Random();
            string[] keykode = new string[5];
            for (int i = 0; i <= 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    int rrr = rndm.Next(1, 4);
                    if (rrr == 1)
                    {
                        anahtar = anahtar + rndm.Next(0, 9);
                    }
                    else
                    {
                        int harf = rndm.Next(65, 91);
                        char karakter = Convert.ToChar(harf);
                        anahtar = anahtar + karakter;
                    }
                }
                if (i != 4)
                    anahtar = anahtar + "-";
            }
            txtlisansanahtari.Text = anahtar;
        }
        private void btnAnahtaruret_Click(object sender, EventArgs e)
        {
            lisansUret();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Lisanslar lisans = new Lisanslar();
            lisans.firmaid = lstFirmaID[cmbxFirmaadi.SelectedIndex];
            lisans.firmaadi = cmbxFirmaadi.SelectedItem.ToString();
            lisans.projekodu = txtpkodu.Text;
            lisans.padi = cmbxprojeadi.SelectedItem.ToString();
            lisans.lisansanahtari = txtlisansanahtari.Text;
            lisans.lisansdurumu = false;
            lisans.adsoyad = "";
            lisans.islemcino = "";
            lisans.lisanstarihi = Convert.ToDateTime(txtktarihi.Text);
            lisans.firmakodu = firmaKodu;
            lisans.pid = lstProjeID[cmbxprojeadi.SelectedIndex];
            try
            {
                int sonuc = 0;
                sonuc = BusinessLogicLayer.BLLLisanslar.insert(lisans);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    lisanslariGetir();
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

        private void btnyenile_Click(object sender, EventArgs e)
        {
            lisanslariGetir();
        }
        private void btnLisanssil_Click(object sender, EventArgs e)
        {
            int[] rowIndex = grdwvAnahtar.GetSelectedRows();
            if (rowIndex.Length > 0)
            {
                Lisanslar m = (Lisanslar)grdwvAnahtar.GetRow(rowIndex[0]);
                if (m != null)
                {
                    DialogResult karar = MessageBox.Show(m.lisansanahtari + " Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (karar == DialogResult.Yes)
                    {
                        BLLLisanslar.delete(Convert.ToInt32(m.id));
                        grdwvAnahtar.DeleteRow(rowIndex[0]);
                    }
                }
            }
        }
    }
}
