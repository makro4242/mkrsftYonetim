using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntityLayer;
using System.ComponentModel.DataAnnotations;

namespace Yonetim
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("kadi", txtkadi.Text);
            dic.Add("sifre", txtsifre.Text);
            Kullanicilar kullanici = BLLKullanicilar.select("*", dic);
            if (kullanici != null)
            {
                this.Hide();
                frmAnaForm frm = new frmAnaForm(kullanici);
                frm.FormClosed += (s, args) => this.Close();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı");
            }
        }

        private void btnsunucuayarlari_Click(object sender, EventArgs e)
        {
            frmSunucu f = new frmSunucu();
            f.ShowDialog();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
         
           
          

        }
    }
}
